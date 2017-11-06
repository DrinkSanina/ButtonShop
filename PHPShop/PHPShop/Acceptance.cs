using System;
using System.Windows.Forms;

namespace PHPShop
{
    public partial class Acceptance : Form
    {
        Product getter = new Product();
        Database second = new Database();
        const String login = "San32";

        public Acceptance(Product let)
        {
            InitializeComponent();
            getter = let;
        }

        private void Acceptance_Load(object sender, EventArgs e)
        {
            label1.Text = getter.Name;
            label4.Text = "По цене - " + getter.Price + " крышек от бутылки";
            label5.Text = " У вас на счете " + second.GetConnect("balance", "users", "login", login) + " пробок";
            pictureBox1.Image = getter.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount;
            int balance = Convert.ToInt32(second.GetConnect("balance", "users", "login", login));
            int ost;
            String result;

            if (Convert.ToString(textBox1.Text) != "")
            {
                amount = Convert.ToInt32(textBox1.Text);
            }
            else
            {
                amount = 1;
            }

            int price = getter.Price * amount;

            if (price <= balance)
            {
                ost = balance - price;
                second.SetConnect("balance", "users", "login", login, Convert.ToString(ost));
                label5.Text = " У вас на счете " + second.GetConnect("balance", "users", "login", login) + " пробок";
                result = "Ура! Вы приобрели товар: \"" + getter.Name + "\" в количестве " + amount + " штук.\nВаш баланс " + ost + " пробок";
            }
            else
            {
                result = "Не так быстро, парниша! У тебя недостаточно пробок!";
            }

            Dialog a = new Dialog(result);
            a.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(textBox1.Text) != "")
            {
                label4.Text = "По цене - " + Convert.ToString(getter.Price * Convert.ToInt32(textBox1.Text) + " крышек от бутылки");
            }
            else
            {
                label4.Text = "По цене - " + getter.Price + " крышек от бутылки";
            }
        }
    }
}
