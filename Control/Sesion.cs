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

        public static bool LogStatus()
        {
            if (User != null) return true;
            else return false;
        }

        public static void LogIn(string username, string password)
        {
            User = UserDao.GetUser(username, password);
            if (LogStatus())
                UserDao.RegisterLogIn(User);
        }

        public static void LogOut()
        {
            if (LogStatus())
            {
#pragma warning disable CS8604 // Possible null reference argument.
                UserDao.RegisterLogOut(User);
#pragma warning restore CS8604 // Possible null reference argument.
                User = null;
            }
        }

        public static bool UserExists(string username)
        {
            if (UserDao.UserExists(username)) return true;
            else return false;
        }
    }
}
