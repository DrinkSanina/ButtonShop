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
