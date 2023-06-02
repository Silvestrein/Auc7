using MySql.Data.MySqlClient;
using System.Data;

namespace Auc7.UserInteract
{
    public class UserAuthorization
    {
        public bool Authorization(string userEmail, string userPassword)
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand(
            "SELECT `email`, `password` FROM `auction`.`user` WHERE `email`=@uE AND `password`=@uP",
            db.GetConnection()
            );
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = userEmail;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return (table.Rows.Count != 0);
        }
    }
}
