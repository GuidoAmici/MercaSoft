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
        public User GetUser(string username, string password)
        {
            DAO dao = new DAO();
            string CheckLogInData = "select * from Users where User = " + username + " and Password = " + password;
            User user = null;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(CheckLogInData);
                dao.ExecuteConsult();
                if (dao.Read() != null)
                {
                    user = new User(
                        (int)dao.Read()["ID"],
                        (string)dao.Read()["Username"],
                        (string)dao.Read()["Password"],
                        (string)dao.Read()["Email"]
                        );

                }

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dao.CloseConnection();
            }
        }
    }
}
