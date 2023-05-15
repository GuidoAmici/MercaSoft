using Data;
using Entities;

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
                RecordDao.AddLogInRecord(User);
        }

        public static void LogOut()
        {
            if (LogStatus())
            {
                RecordDao.AddLogOutRecord(User);
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
