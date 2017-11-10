using System;
using System.Windows.Forms;

namespace PHPShop.AssortmentEngine
{
    class AssortmentLoad
    {
        const String pictureVault = "http://f0169802.xsph.ru/pictures/"; //Путь к папке с картинками на сервере
        DatabaseMethods dbMet = new DatabaseMethods();

        public AssortmentLoad(Panel panel, EventHandler Picture_Click)
        {
            int m = 0;
            int n = 5;
            int lastID = dbMet.GetMaxConnect("max(id)", "products");
            String pictureBoxName = "";
            PictureBox[] pictureBox = new PictureBox[lastID + 1];
            Label[] label = new Label[lastID + 1];
            for (int currentID = 1; currentID < pictureBox.Length; currentID++)
            {
                pictureBoxName = dbMet.GetConnect("id", "products", "id", Convert.ToString(currentID));
                pictureBox[currentID] = new System.Windows.Forms.PictureBox();
                pictureBox[currentID].Location = new System.Drawing.Point(m, n);
                pictureBox[currentID].Size = new System.Drawing.Size(100, 100);
                pictureBox[currentID].Name = Convert.ToString(currentID);
                String path = pictureVault + dbMet.GetConnect("picture", "products", "id", Convert.ToString(currentID));
                pictureBox[currentID].ImageLocation = path;
                pictureBox[currentID].TabIndex = currentID;
                pictureBox[currentID].TabStop = false;
                pictureBox[currentID].Click += new EventHandler(Picture_Click);

                label[currentID] = new System.Windows.Forms.Label();
                label[currentID].Location = new System.Drawing.Point(m + 19, n + 104);
                label[currentID].Text = dbMet.GetConnect("name", "products", "id", Convert.ToString(currentID));
                label[currentID].Size = new System.Drawing.Size(83, 12);

                panel.Controls.Add(pictureBox[currentID]);
                panel.Controls.Add(label[currentID]);
                m = m + 110;

                if (currentID % 5 == 0)
                {
                    m = 0;
                    n += 150;
                }
            }
        }
    }
}