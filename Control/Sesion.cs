using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public static class Sesion
    {
        internal static User? User;

        public static bool SesionStatus()
        {
            if (User == null) return false;
            else return true;
        }

        public static bool LogIn(string username, string password)
        {
            UserDao userDao = new UserDao();
            User = userDao.GetUser(username, password);
            if (User == null) return false;
            else return true;
        }

        public static void LogOut()
        {
            User = null;
        }
    }
}
