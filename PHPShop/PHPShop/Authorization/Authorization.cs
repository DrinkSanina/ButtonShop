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
                MessageBox.Show("Ошибка регистрации. " + ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            dbMethods.LoginUser(LoginTextBox.Text.ToString(), PassTextBox.Text.ToString());
            MessageBox.Show("Done");
        }
    }
}
