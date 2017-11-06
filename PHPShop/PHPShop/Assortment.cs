using System;
using System.Windows.Forms;
using PHPShop.Products;

namespace PHPShop
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Database first = new Database();

        private void LetterA_Click(object sender, EventArgs e)
        {
            Letter letterA = new Letter(
                "1", 
                first.GetConnect("name", "products", "id", "1"), 
                Properties.Resources.A, 
                Convert.ToInt32(first.GetConnect("price", "products", "id", "1"))
                );
            Acceptance form = new Acceptance(letterA);
            form.Visible = true;
        }

        private void LetterB_Click(object sender, EventArgs e)
        {
            Letter letterB = new Letter(
                "2",
                first.GetConnect("name", "products", "id", "2"),
                Properties.Resources.A,
                Convert.ToInt32(first.GetConnect("price", "products", "id", "2"))
                );
            Acceptance form = new Acceptance(letterB);
            form.Visible = true;
        }
    }
}
