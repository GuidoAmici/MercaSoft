using Entities;

namespace Control
{
    public class UserDao
    {
        // CREATE methods

        public static User GetUser(string username, string password)
        {
            DAO dao = new();
            string query = "select * from Users where Username = @username and Password = @password";
            User user = null;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@username", username);
                dao.SetParameter("@password", password);
                dao.ExecuteConsult();

                while (dao.Reader.Read())
                {
                    user = new(
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

        public static bool UserExists(string username)
        {
            DAO dao = new();
            string query = "select * from users where Username = @username";

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@username", username);
                dao.ExecuteConsult();

                return dao.Reader.Read();
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        internal static User GetUserByID(int userID)
        {
            DAO dao = new();
            string query = "select * from Users where ID = @userID";

            User user;

            try
            {
                dao.OpenConnection();
                dao.SetConsult(query);
                dao.SetParameter("@userID", userID);
                dao.ExecuteConsult();

                dao.Reader.Read();

                user = new(
                    (int)dao.Reader["ID"],
                    (string)dao.Reader["Username"],
                    (string)dao.Reader["Password"],
                    (string)dao.Reader["Email"]
                );

                return user;
            }
            catch (Exception) { throw; }
            finally { dao.CloseConnection(); }
        }

        // READ methods

        // UPDATE methods

        // DELETE methods
    }
}
