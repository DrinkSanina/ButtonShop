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

            CloseConnection();
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
            CloseConnection();
        }

        /// <summary>
        /// Регестрация пользователя в БД
        /// </summary>
        public void RegUser(String login, String password, Decimal balance)
        {
            char[] badSym = { ' ', '!', '\"', '№', ';', '%', ':', '?', '*', '(', ')', '_', '+', '-', '!', '@', '#', '$', '^', '&', '*', '[', ']', '{', '}', '\\' };
            login = login.Trim(' ');
            password = password.Trim(' ');
            int test = -1; //Проверка на символы, которые нельзя вводить
            test = login.IndexOfAny(badSym);
            test = password.IndexOfAny(badSym);
            string sql;
            string res;

            if (test != -1 || password == "" || login == "")
            {
                MessageBox.Show("Введите правильный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            sql = $"SELECT EXISTS(SELECT * FROM users WHERE login='{login}')";
            MySqlCommand command = new MySqlCommand(sql, ConnectToDB);
            res = command.ExecuteScalar().ToString();    
            CloseConnection();

            if (res == "0")
            {
                sql = $"INSERT INTO users (login,password,balance) VALUES('{login}','{password}','{balance}')";
                command = new MySqlCommand(sql, ConnectToDB);
                command.ExecuteScalar();
                MessageBox.Show("Вы успешно зарегестрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пользователь с данным логином уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            CloseConnection();
        }

        /// <summary>
        /// Вход пользователя в приложение
        /// </summary>
        public bool LoginUser(String login, String password)
        {
            login = HttpUtility.HtmlAttributeEncode(login);
            password = HttpUtility.HtmlAttributeEncode(password);
            login = login.Replace('/', ' ');
            password = password.Replace('/', ' ');
            login = login.Trim(' ');
            password = password.Trim(' ');
            string res;
            string sql;

            sql = $"SELECT EXISTS(SELECT * FROM users WHERE login='{login}')";
            MySqlCommand command = new MySqlCommand(sql, ConnectToDB);
            res = command.ExecuteScalar().ToString();
            CloseConnection();

            if(res == "1")
            {
                sql = $"SELECT password FROM users WHERE login = '{login}'";
                command = new MySqlCommand(sql, ConnectToDB);
                res = command.ExecuteScalar().ToString();
                CloseConnection();
                if(res == password)
                {
                    MessageBox.Show("Вы успешно вошли", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Неправильный пароль!", "Вход", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Данного пользователя не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
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
            CloseConnection();
            return int_result;          
        }
    }
}
