using MySql.Data.MySqlClient;
using System.Data;

namespace Auc7.UserInteract
{
    public class UserRegistration
    {
        public bool Registration(string userEmail, string userPassword, string userName, DateTime userRegistrationTime)
        {
            DB db = new DB();
            if (IsUserExists(userEmail))
            {
                return false;
            }
            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(
            "INSERT INTO `auction`.`user` (`name`,`email`, `password`, `registration_time`) VALUES (@uN, @uE,@uP, @uRE)",
            db.GetConnection()
            );

            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = userEmail;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = userPassword;
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@uRE", MySqlDbType.VarChar).Value = userRegistrationTime;

            if (command.ExecuteNonQuery() == 1)
            {
                db.CloseConnection();
                return true;
            }
            db.CloseConnection();
            return false;
        }
        private Boolean IsUserExists(string userEmail)
        {
            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `email` FROM `auction`.`user` WHERE `email`=@uE", db.GetConnection());
            command.Parameters.Add("@uE", MySqlDbType.VarChar).Value = userEmail;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return (table.Rows.Count != 0);
        }

    }
}
