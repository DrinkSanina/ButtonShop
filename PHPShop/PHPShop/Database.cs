using MySql.Data.MySqlClient;

namespace PHPShop
{
    class DataBase
    {
        protected MySqlConnection ConnectToDB
        {
            get
            {
                MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder()
                {
                    Server = "Test",
                    Database = "",
                    UserID = "",
                    Password = ""
                };
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = mysqlCSB.ConnectionString;
                con.Open();
                return con;
            }
        }
    }
}
