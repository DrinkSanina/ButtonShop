using System;
using MySql.Data.MySqlClient;
namespace PHPShop
{
    class Database
    {
        MySqlConnection ConnectToDB
        {
            get
            {
                const string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
                const string userName = "Admin"; // Имя пользователя
                const string dbName = "shop"; //Имя базы данных
                const string port = "3306"; // Порт для подключения
                const string password = "despacito"; // Пароль для подключения
                const string connStr = "server=" + serverName +
                     ";user=" + userName +
                     ";database=" + dbName +
                     ";port=" + port +
                     ";password=" + password + ";";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                return conn;
            }
        }

        /// <summary>
        /// Получить определённые данные из БД
        /// </summary>
        /// <returns>Строка с полученными данными</returns>
        public String GetConnect(String line, String table, String cond, String sd_cond)
        {
            string sql = "SELECT " + line + " FROM " + table + " WHERE " + cond + " = '" + sd_cond + "'";
            MySqlCommand command = new MySqlCommand(sql, ConnectToDB);
            string result = command.ExecuteScalar().ToString();
            return result;
        }

        /// <summary>
        /// Заменяет величину в БД
        /// </summary>
        public void SetConnect(String line, String table, String cond, String sd_cond, String value)
        {
            string sql = "UPDATE " + table + " SET " + line + " = " + value + " WHERE " + cond + " = '" + sd_cond + "'";
            MySqlCommand command = new MySqlCommand(sql, ConnectToDB);
            command.ExecuteScalar();
        }

        /// <summary>
        /// Регестрация пользователя в БД
        /// </summary>
        public void RegUser(String login, String password, Double balance)
        {
            password = password.Trim('!', '\"', '№', ';', '%', ':', '?', '*', '(', ')', '_', '+', '-', '!', '@', '#', '$','^','&','*','[',']','{','}');
            string sql = $"INSERT INTO users (login,password,balance) VALUES('{login}','{password}','{balance}')";
            MySqlCommand command = new MySqlCommand(sql, ConnectToDB);
            command.ExecuteScalar();
        }
    }
}
