using System;
using System.Windows.Forms;
using PHPShop.AssortmentEngine;

namespace PHPShop
{
    public partial class Assortment : Form
    {
        string login;

        /// <summary>
        /// Создаем класс Assortment
        /// </summary>
        /// <param name="login">Логин, полученный после входа/регистрации пользователя</param>
        public Assortment(string login)
        {
            InitializeComponent();
            this.login = login;
            UserNameLabel.Text = $"Добро пожаловать, {login}";
        }

        /// <summary>
        /// Событие нажатия на pictureBox из Ассортимента. Вызывает Acceptance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Picture_Click(object sender, EventArgs e)
        {
            PictureBox example = (PictureBox)sender;
            Acceptance form = new Acceptance(example,login);
            form.ShowDialog();
        }

        /// <summary>
        /// Событие загрузки динамического Ассортимента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
