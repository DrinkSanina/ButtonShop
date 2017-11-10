using System;
using System.Windows.Forms;
using PHPShop.AssortmentEngine;

namespace PHPShop
{
    public partial class Assortment : Form
    {
        string login;

        public Assortment(string login)
        {
            InitializeComponent();
            this.login = login;
            UserNameLabel.Text = $"Добро пожаловать, {login}";
        }

        protected void Picture_Click(object sender, EventArgs e)
        {
            PictureBox example = (PictureBox)sender;
            Acceptance form = new Acceptance(example,login);
            form.ShowDialog();
        }

        private void Assortment_Load(object sender, EventArgs e)
        {
            new AssortmentLoad(panel1, Picture_Click);
        }

        private void Assortment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
