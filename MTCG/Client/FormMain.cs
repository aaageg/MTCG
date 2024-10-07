using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FormMain : Form
    {
        private string userName;
        private string userGold;
        private string userToken;

        public FormMain(string name, string gold, string token)
        {
            InitializeComponent();
            this.userName = name;
            this.userGold = gold;
            this.userToken = token;

            
            lalName.Text = $"Welcome, {name}";
            lalGold.Text = $"Gold: {gold}";
            lalToken.Text = $"Token: {token}";
        }
    }
}
