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
                    Server = "", //Адрес сервера 
                    Database = "", //Имя БД
                    UserID = "", //login пользователя
                    Password = "" //Пароль
                };
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = mysqlCSB.ConnectionString;
                con.Open();
                return con;
            }
        }
    }
}
