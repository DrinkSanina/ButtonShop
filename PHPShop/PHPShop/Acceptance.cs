using System;
using System.Windows.Forms;

namespace PHPShop
{
    public partial class Acceptance : Form
    {
        Product currentProduct = new Product();
        DatabaseMethods second = new DatabaseMethods();

        string login;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="get"></param>
        /// <param name="login"></param>
        public Acceptance(PictureBox get, string login)
        {
            InitializeComponent();
            this.login = login;
            currentProduct.ID = get.Name;
            currentProduct.Name = second.GetConnect("name", "products", "id", currentProduct.ID);
            currentProduct.Price = Convert.ToDecimal(second.GetConnect("price", "products", "id", currentProduct.ID));
            currentProduct.Image = get.Image;
            amount.Maximum = Convert.ToInt32(second.GetConnect("amount", "products", "id", currentProduct.ID));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Acceptance_Load(object sender, EventArgs e)
        {
            productName.Text = currentProduct.Name;
            priceLabel.Text = $"По цене - {currentProduct.Price} крышек от бутылки";
            balanceLabel.Text = $"У вас на счете {second.GetConnect("balance", "users", "login", login)} пробок";
            pictureBox1.Image = currentProduct.Image;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Buy_Click(object sender, EventArgs e)
        {
            int productAmount = Convert.ToInt32(this.amount.Value);
            decimal balance = Convert.ToDecimal(second.GetConnect("balance", "users", "login", login));
            decimal ost;
            int productOst;

            decimal price = currentProduct.Price * productAmount;

            if (price <= balance)
            {
                ost = balance - price;
                productOst = Convert.ToInt32(amount.Maximum) - productAmount;
                second.SetConnect("amount", "products", "id", currentProduct.ID, Convert.ToString(productOst));
                second.SetConnect("balance", "users", "login", login, Convert.ToString(ost));
                balanceLabel.Text = $"У вас на счете {second.GetConnect("balance", "users", "login", login)} пробок";
                MessageBox.Show($"Ура! Вы приобрели товар: \"{currentProduct.Name}\" в количестве {productAmount} штук.\nВаш баланс {ost} пробок", "Покупка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не так быстро, парниша! У тебя недостаточно пробок!", "Покупка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AmountChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(amount.Value) != "")
            {
                priceLabel.Text = $"По цене - {Convert.ToString(currentProduct.Price * amount.Value + " крышек от бутылки")}";
            }
            else
            {
                priceLabel.Text = $"По цене - {currentProduct.Price} крышек от бутылки";
            }
        }

        private void Acceptance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
