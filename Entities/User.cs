using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int ID { get; internal set; }
        public string Username { get; internal set; }
        internal string Password { get; set; }
        public string Email { get; internal set; }

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
