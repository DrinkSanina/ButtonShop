using System;
using System.Windows.Forms;
using PHPShop.Products;

namespace PHPShop
{
    public partial class Assortment : Form
    {

        public Assortment()
        {
            InitializeComponent();
        }

        DatabaseMethods first = new DatabaseMethods();

        private void LetterA_Click(object sender, EventArgs e)
        {
            Letter letterA = new Letter(
                "1", 
                first.GetConnect("name", "products", "id", "1"), 
                Properties.Resources.A, 
                Convert.ToDecimal(first.GetConnect("price", "products", "id", "1"))
                );
            Acceptance form = new Acceptance(letterA);
            form.Visible = true;
        }

        private void LetterB_Click(object sender, EventArgs e)
        {
            Letter letterB = new Letter(
                "2",
                first.GetConnect("name", "products", "id", "2"),
                Properties.Resources.B,
                Convert.ToDecimal(first.GetConnect("price", "products", "id", "2"))
                );
            Acceptance form = new Acceptance(letterB);
            form.Visible = true;
        }

        private void RegB_Click(object sender, EventArgs e)
        {
            try
            {
                first.RegUser(LoginTBox.Text.ToString(), PasswordTBox.Text.ToString(), Convert.ToDouble(BalanceTBox.Text.ToString()));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введён неверный баланс", "Ошибка", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Done");
        }
    }
}
