using System.Data.SqlClient;
using Npgsql;

namespace Farmacia_SaoPaulo
{
    public class DatabaseConnector
    {

        private static NpgsqlConnection connection;
        
        public static NpgsqlConnection getConnection()
        {
            if (connection == null)
            {
                const string urlConnection = "Host=localhost:5433;Username=postgres;Password=postgres;Database=postgres";
                connection = new NpgsqlConnection(urlConnection);
            }
            return connection;
        }
        
    }
}