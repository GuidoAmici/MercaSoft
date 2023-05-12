using System.Data.SqlClient;

namespace Control
{
    public class DAO
    //DAO = Data Access Object, es un objeto a través del cual establecemos una conexión con la base de datos.
    //- Para pedir algo a la base de datos, instaciamos un objeto de clase DAO, abrimos la conexión, setteamos la consulta-
    //- y ejecutamos la consulta. Una vez ejecutada, le pediremos al objeto Reader, a través de la función Read() -
    //- los datos que haya devuelto la consulta.
    {
        private readonly string ServerName = "CHALLENGER\\SQLEXPRESS";
        private readonly string DBName = "MercaSoftDB";

        internal SqlConnection Connection { get; private set; }
        internal SqlCommand Command { get; private set; }
        internal SqlDataReader Reader { get; private set; }

        public DAO()
        {
            Connection = new SqlConnection($"Data Source = {ServerName}; Initial Catalog = {DBName}; Integrated Security = SSPI");
            Command = new SqlCommand();
        }

        public void OpenConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void SetConsult(string consulta)
        {
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = consulta;
        }

        public void SetParameter(string parameterName, object value)
        {
            Command.Parameters.AddWithValue(parameterName, value);
        }

        public void ExecuteConsult()
        {
            try
            {
                Command.Connection = Connection;
                Reader = Command.ExecuteReader();
            }
            catch (Exception)
            {

                throw;
            }
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