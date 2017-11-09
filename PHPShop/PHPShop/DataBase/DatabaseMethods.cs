<<<<<<< HEAD:PHPShop/PHPShop/DataBase/DatabaseMethods.cs
﻿using System;
using MySql.Data.MySqlClient;

namespace PHPShop
{
    class DatabaseMethods : DataBase
    {
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
            password = password.Trim(' ', '!', '\"', '№', ';', '%', ':', '?', '*', '(', ')', '_', '+', '-', '!', '@', '#', '$', '^', '&', '*', '[', ']', '{', '}');
            string sql = $"INSERT INTO users (login,password,balance) VALUES('{login}','{password}','{balance}')";
            MySqlCommand command = new MySqlCommand(sql, ConnectToDB);
            command.ExecuteScalar();
=======
﻿using MySql.Data.MySqlClient;

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
                    Server = "Test", //Адрес сервера 
                    Database = "", //Имя БД
                    UserID = "", //login пользователя
                    Password = "" //Пароль
                };
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = mysqlCSB.ConnectionString;
                con.Open();
                return con;
            }
>>>>>>> 0557884... Merge pull request #1 from San32x/Dev:PHPShop/PHPShop/Database.cs
        }
    }
}
