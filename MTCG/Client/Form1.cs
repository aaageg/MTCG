using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Email and Password cannot be empty.");
                return;
            }

            
            await SendMessageToServer(email, password);
        }

        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.ShowDialog();
        }

        
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private async Task SendMessageToServer(string email, string password)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://127.0.0.1:8000/login"; 

                    var postData = new
                    {
                        Email = email,
                        Password = password
                    };

                    string json = JsonConvert.SerializeObject(postData);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        
                        string responseBody = await response.Content.ReadAsStringAsync();

                        
                        var userResponse = JsonConvert.DeserializeObject<dynamic>(responseBody);

                        
                        string name = userResponse.Name;
                        string gold = userResponse.Gold;
                        string token = userResponse.Token;

                        
                        MessageBox.Show($"Login successful! Welcome {name}");

                        
                        FormMain mainForm = new FormMain(name, gold, token);
                        mainForm.Show();
                        this.Hide(); 
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check if your email and password are correct.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to connect to server:{ex.Message}");
            }
        }
    }
}
