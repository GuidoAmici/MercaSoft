using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DataAccess
{
    public class DAO
    {
        private readonly string ServerName = "CHALLENGER\\SQLEXPRESS";
        private readonly string DBName = "MercaSoftDB";

        private SqlConnection Connection;
        private SqlCommand Command;
        private SqlDataReader Reader;



        public DAO()
        {
            Connection = new SqlConnection("Data Source=" + ServerName + ";Initial catalog=" + DBName + ";Security=SSPI");
            Command = new SqlCommand();
        }

        public void OpenConnection()
        {
            if (Connection != null) Connection.Open();
            else throw new Exception();
        }

        public void SetConsult(string consulta)
        {
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = consulta;
        }

        public void ExecuteConsult()
        {
            try
            {
                Command.Connection = Connection;
                Reader = Command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public SqlDataReader Read()
        {
            return Reader;
        }

        public void CloseConnection()
        {
            Connection.Close();
        }

        ~DAO()
        {
            Connection.Dispose();
            Command.Dispose();
        }
    }
}