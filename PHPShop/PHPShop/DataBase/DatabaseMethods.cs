using System;
using MySql.Data.MySqlClient;
using System.Web;
using System.Windows.Forms;

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
            ConnectToDB.Close();
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
            ConnectToDB.Close();
        }

        /// <summary>
        /// Регестрация пользователя в БД
        /// </summary>
        public void RegUser(String login, String password, Decimal balance)
        {
            char[] badSym = { ' ', '!', '\"', '№', ';', '%', ':', '?', '*', '(', ')', '_', '+', '-', '!', '@', '#', '$', '^', '&', '*', '[', ']', '{', '}','\\' };
            login = login.Trim(' ');
            password = password.Trim(' ');
            int test = -1; //Проверка на символы, которые нельзя вводить
            test = login.IndexOfAny(badSym);
            test = password.IndexOfAny(badSym);
            if(test != -1)
            {
                MessageBox.Show("Введите правильный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectToDB.Close();
                return;
            }
            string sql = $"INSERT INTO users (login,password,balance) VALUES('{login}','{password}','{balance}')";
            MySqlCommand command = new MySqlCommand(sql, ConnectToDB);
            command.ExecuteScalar();
            ConnectToDB.Close();
            MessageBox.Show("Done");
        }

        /// <summary>
        /// Вход пользователя в приложение
        /// </summary>
        public void LoginUser(String login, String password)
        {
            login = HttpUtility.HtmlAttributeEncode(login);
            password = HttpUtility.HtmlAttributeEncode(password);
            login = login.Replace('/', ' ');
            password = password.Replace('/', ' ');
            login = login.Trim(' ');
            password = password.Trim(' ');
            string sql = $"INSERT INTO users (login,password,balance) VALUES('{login}','{password}')";
            //MySqlCommand command = new MySqlCommand(sql, ConnectToDB)
            //command.ExecuteScalar();
            ConnectToDB.Close();
        }

        /// <summary>
        /// Получить максимальное значение ключа БД
        /// </summary>
        /// <returns>Натуральное число с полученными данными</returns>
        public int GetMaxConnect(String line, String table)
        {
            string sql = "SELECT " + line + " FROM " + table;
            MySqlCommand command = new MySqlCommand(sql, ConnectToDB);
            string result = command.ExecuteScalar().ToString();
            int int_result = Convert.ToInt32(result);
            return int_result;
        }
    }
}
