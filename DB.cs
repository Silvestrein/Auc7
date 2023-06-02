using MySql.Data.MySqlClient;
using System.Data;

namespace Auc7

{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=root;database=auction");

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
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

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
