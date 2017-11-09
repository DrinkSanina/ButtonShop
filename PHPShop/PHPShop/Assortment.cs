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
                first.RegUser(LoginTBox.Text.ToString(), PasswordTBox.Text.ToString(), Convert.ToDecimal(BalanceTBox.Text.ToString()));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введён неверный баланс", "Ошибка", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Done");
        }


        private void Assortment_Load(object sender, EventArgs e)
        {
            int m = 5;
            int n = 5;
            int lastID = first.GetMaxConnect("max(id)", "products");
            String pictureBoxName = "";
            PictureBox[] pictureBox = new PictureBox[lastID + 1];
            for (int currentID = 1; currentID < pictureBox.Length; currentID++)
            {
                pictureBoxName = first.GetConnect("id", "products", "id", Convert.ToString(currentID));
                pictureBox[currentID] = new System.Windows.Forms.PictureBox();
                pictureBox[currentID].Location = new System.Drawing.Point(m, n);
                pictureBox[currentID].Size = new System.Drawing.Size(100, 100);
                pictureBox[currentID].Name = Convert.ToString(currentID);
                pictureBox[currentID].Image = Properties.Resources.A;
                pictureBox[currentID].TabIndex = currentID;
                pictureBox[currentID].TabStop = false;
                pictureBox[currentID].Click += new EventHandler(LetterA_Click);
                panel1.Controls.Add(pictureBox[currentID]);
                m = m + 100;


                //    if (currentID % 10 == 0)
                //    {
                //        m = 10;
                //        n += 10;
                //    }

            }
        }
    }
}
