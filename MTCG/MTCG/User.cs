using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTCG
{
    internal class User
    {
     private string name;
     public string Name 
        { 
            get { return name; }
            set {  name = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string gold;
        public string Gold
        {
            get { return gold; }
            set { gold = value; }
        }

        private string token;
        public string Token
        {
            get { return token; }
            set { token = value; }
        }

        // public Card[] Cards { get; set; }
        public void display()
        {
            Console.WriteLine("name:{0},gold{1},token{2}",name,gold,token);
        }

    }
}
