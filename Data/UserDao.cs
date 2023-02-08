using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class UserDao
    {
        public static User GetUser(string username, string password)
        {
            DAO dao = new();
            string CheckLogInData = "select * from Users where Username = @username and Password = @password";
            User user = null;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(CheckLogInData);
                dao.SetParameter("@username", username);
                dao.SetParameter("@password", password);
                dao.ExecuteConsult();

                if (dao.Reader.Read())
                {
                    user = new (
                        (int)dao.Reader["ID"],
                        (string)dao.Reader["Username"],
                        (string)dao.Reader["Password"],
                        (string)dao.Reader["Email"]
                        );
                }

                return user;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static void RegisterLogIn(User user)
        {
            DAO dao = new();
            string RegisterSesion = "insert into LogHistory (UserID,LogType) values (@userID,'Log In')";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(RegisterSesion);
                dao.SetParameter("@userID", user.ID);
                dao.ExecuteConsult();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static void RegisterLogOut(User user)
        {
            DAO dao = new();
            string RegisterSesion = "insert into LogHistory (UserID,LogType) values (@userID,'Log Out')";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(RegisterSesion);
                dao.SetParameter("@userID", user.ID);
                dao.ExecuteConsult();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        public static bool UserExists(string username)
        {
            DAO dao = new();
            string CheckUserExistance = "select * from users where Username = @username";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(CheckUserExistance);
                dao.SetParameter("@username", username);
                dao.ExecuteConsult();
                if (dao.Reader.Read() != null) return true;
                else return false;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }
    }
}
