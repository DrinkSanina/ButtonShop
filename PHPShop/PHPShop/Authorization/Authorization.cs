using System;
using System.Windows.Forms;

namespace PHPShop
{
    public partial class Authorization : Form
    {
        DatabaseMethods dbMethods = new DatabaseMethods();
        public Authorization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие на кнопку регистрации. Проверяет, есть ли ошибки при регистрации, и если все чисто - регистриует нового пользователя в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbMethods.RegUser(LoginTextBox.Text.ToString(), PassTextBox.Text.ToString(),100);
            }
            catch (System.FormatException ex)
            {
                MessageBox.Show("Ошибка регистрации.\n" + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// Нажатие на кнопку входа. Осматривает БД на предмет совпадения логина/пароля и соответственно выдает ошибку или дает доступ к магазину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbMethods.LoginUser(LoginTextBox.Text.ToString(), PassTextBox.Text.ToString()) == true)
                {
                    Assortment a = new Assortment(LoginTextBox.Text.ToString());
                    a.Show();
                    Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка входа.\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
