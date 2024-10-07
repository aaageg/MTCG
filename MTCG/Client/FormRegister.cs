using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Client
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                //MessageBox.Show("所有字段不能为空");
                MessageBox.Show("All fields cannot be empty");
                return;
            }

            
            await SendRegisterRequest(name, email, password);
        }

        
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private async Task SendRegisterRequest(string name, string email, string password)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "http://127.0.0.1:8000/register"; 

                    var postData = new
                    {
                        Name = name,
                        Email = email,
                        Password = password
                    };

                    string json = JsonConvert.SerializeObject(postData);
                    HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        
                        string responseBody = await response.Content.ReadAsStringAsync();
                        //MessageBox.Show("注册成功！" + responseBody);
                        MessageBox.Show("Registration successful!" + responseBody);
                        this.Close(); 
                    }
                    else
                    {
                        
                        string responseBody = await response.Content.ReadAsStringAsync();
                        //MessageBox.Show("注册失败：" + responseBody);
                        MessageBox.Show("Registration failed:" + responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"无法连接到服务器：{ex.Message}");
                MessageBox.Show($"Unable to connect to server:{ex.Message}");
            }
        }
    }
}
