using MySql.Data.MySqlClient;

namespace PHPShop
{
    class DataBase
    {
        MySqlConnection con;
        protected MySqlConnection ConnectToDB
        {
            get
            {
                MySqlConnectionStringBuilder mysqlCSB = new MySqlConnectionStringBuilder()
                {
                    Server = "localhost", //Адрес сервера 
                    Database = "buttonshop", //Имя БД
                    UserID = "root", //login пользователя
                    Password = "despacito" //Пароль
                };
                con = new MySqlConnection();
                con.ConnectionString = mysqlCSB.ConnectionString;
                con.Open();
                return con;
            }

        }

        public void CloseConnection()
        {
            con.Close();
        }
    }
}
