using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        private int ID { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }

        public User()
        {
            ID = 0;
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
        }

        public User(int id, string username, string password, string email)
        {
            ID = id;
            Username = username;
            Password = password;
            Email = email;
        }

        public override string ToString()
        {
            if (ID == 0) return "Empty user";
            else return Username;
        }
    }
}
