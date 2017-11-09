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
        const String pictureVault = "http://f0169802.xsph.ru/pictures/"; //Путь к папке с картинками на сервере

        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox example = (PictureBox) sender;
            Acceptance form = new Acceptance(example);
            form.Visible = true;
        }
 

        private void Assortment_Load(object sender, EventArgs e)
        {
            
            int m = 0;
            int n = 5;
            int lastID = first.GetMaxConnect("max(id)", "products");
            String pictureBoxName = "";
            PictureBox[] pictureBox = new PictureBox[lastID + 1];
            Label[] label = new Label[lastID + 1];
            for (int currentID = 1; currentID < pictureBox.Length; currentID++)
            {
                pictureBoxName = first.GetConnect("id", "products", "id", Convert.ToString(currentID));
                pictureBox[currentID] = new System.Windows.Forms.PictureBox();
                pictureBox[currentID].Location = new System.Drawing.Point(m, n);
                pictureBox[currentID].Size = new System.Drawing.Size(100, 100);
                pictureBox[currentID].Name = Convert.ToString(currentID);
                String path = pictureVault + first.GetConnect("picture", "products", "id", Convert.ToString(currentID));
                pictureBox[currentID].ImageLocation = path;
                pictureBox[currentID].TabIndex = currentID;
                pictureBox[currentID].TabStop = false;
                pictureBox[currentID].Click += new EventHandler(Picture_Click);

                label[currentID] = new System.Windows.Forms.Label();
                label[currentID].Location = new System.Drawing.Point(m + 19, n + 104);
                label[currentID].Text = first.GetConnect("name", "products", "id", Convert.ToString(currentID));
                label[currentID].Size = new System.Drawing.Size(83, 12);

                panel1.Controls.Add(pictureBox[currentID]);
                panel1.Controls.Add(label[currentID]);
                m = m + 110;

                    if (currentID % 3 == 0)
                    {
                        m = 0;
                        n += 150;
                    }
            }
        }
    }
}
