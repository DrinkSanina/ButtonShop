using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PHPShop
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Database first = new Database();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
            Product letter = new Product()
            {
                ID = "1",
                image = Properties.Resources.A
            };
            letter.price = Convert.ToInt32(first.GetConnect("price", "products", "id", letter.ID));
            letter.name = first.GetConnect("name", "products", "id", letter.ID);
            Acceptance form = new Acceptance(letter);
            form.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Product letter = new Product()
            {
                ID = "2", 
                image = Properties.Resources.B
            };
            
            letter.price = Convert.ToInt32(first.GetConnect("price", "products", "id", letter.ID));
            letter.name = first.GetConnect("name", "products", "id", letter.ID);
            Acceptance form = new Acceptance(letter);
            form.Visible = true;
        }

        
    }
}
