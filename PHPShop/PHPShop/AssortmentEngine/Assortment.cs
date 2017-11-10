using System;
using System.Windows.Forms;
using PHPShop.AssortmentEngine;

namespace PHPShop
{
    public partial class Assortment : Form
    {

        public Assortment()
        {
            InitializeComponent();
        }

        protected void Picture_Click(object sender, EventArgs e)
        {
            PictureBox example = (PictureBox)sender;
            Acceptance form = new Acceptance(example);
            form.ShowDialog();
        }

        private void Assortment_Load(object sender, EventArgs e)
        {
            new AssortmentLoad(panel1);
        }

        private void Assortment_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
