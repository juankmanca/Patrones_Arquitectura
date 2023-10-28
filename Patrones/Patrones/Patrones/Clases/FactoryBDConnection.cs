using System.Data;
using System.Data.SqlClient;


namespace Patrones.Patrones.Clases
{
    public class SQLServerConnection
    {
        private string connectionString;
        private SqlConnection connection;

        public SQLServerConnection(string server, string database, string username, string password)
        {
            // Crear la cadena de conexión
            connectionString = $"Server={server};Database={database};User Id={username};Password={password};";
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            OpenConnection();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                CloseConnection();
                return dataTable;
            }
        }

        public int InsertDataByQuery(string query)
        {
            OpenConnection();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int rowsAffected = command.ExecuteNonQuery();

                CloseConnection();
                return rowsAffected;
            }
        }
    }

}
