using System.Data.SqlClient;

namespace DataAccess
{
    public class DAO
    {
        private readonly string ServerName = "CHALLENGER\\SQLEXPRESS";
        private readonly string DBName = "MercaSoftDB";

        private SqlConnection Connection { get; }
        private SqlCommand Command{get; }
        private SqlDataReader Reader { get; }

        public DAO() { 
            Connection= new SqlConnection("Data Source=" + ServerName + ";Initial catalog=" + DBName + ";Security=SSPI");
            Command= new SqlCommand();
        }


    }
}