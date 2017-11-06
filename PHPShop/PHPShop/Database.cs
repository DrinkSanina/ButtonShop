using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace PHPShop
{
    class Database
    {
        public String GetConnect(String line, String table, String cond, String sd_cond)
        {
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "Admin"; // Имя пользователя
            string dbName = "shop"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "despacito"; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {    
                conn.Open();
            }
            catch(Exception e)
            {
              MessageBox.Show("Нет подключения","Ошибка");
              return null;
            }

            string sql = "SELECT " + line + " FROM " + table + " WHERE " + cond + " = '" + sd_cond + "'";
            
            MySqlCommand command = new MySqlCommand(sql, conn);
            string result = command.ExecuteScalar().ToString();
            return result;

        }
        public void SetConnect(String line, String table, String cond, String sd_cond, String value)
        {
            string serverName = "localhost"; // Адрес сервера (для локальной базы пишите "localhost")
            string userName = "Admin"; // Имя пользователя
            string dbName = "shop"; //Имя базы данных
            string port = "3306"; // Порт для подключения
            string password = "despacito"; // Пароль для подключения
            string connStr = "server=" + serverName +
                ";user=" + userName +
                ";database=" + dbName +
                ";port=" + port +
                ";password=" + password + ";";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            
            string sql = "UPDATE " + table +" SET " + line +" = " + value + " WHERE " + cond + " = '" + sd_cond + "'";
            MySqlCommand command = new MySqlCommand(sql, conn);
            command.ExecuteScalar();
        }
    }
}
