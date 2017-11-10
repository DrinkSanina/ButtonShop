using System;
using System.Windows.Forms;

namespace PHPShop.AssortmentEngine
{
    class AssortmentLoad
    {
        const String pictureVault = "http://f0169802.xsph.ru/pictures/"; //Путь к папке с картинками на сервере
        DatabaseMethods dbMet = new DatabaseMethods();

        /// <summary>
        /// Массивный метод динамической загрузки товаров в таблицу
        /// </summary>
        /// <param name="panel">Панелька, в которую всё будет грузиться.</param>
        /// <param name="Picture_Click">Метод клика на картинку для того, чтобы привязать его к картинке товара.</param>
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
                String path = pictureVault + dbMet.GetConnect("picture", "products", "id", Convert.ToString(currentID));
                pictureBoxName = dbMet.GetConnect("id", "products", "id", Convert.ToString(currentID));
                pictureBox[currentID] = new System.Windows.Forms.PictureBox
                {
                    Location = new System.Drawing.Point(m, n),
                    Size = new System.Drawing.Size(100, 100),
                    Name = Convert.ToString(currentID),
                    ImageLocation = path,
                    TabIndex = currentID,
                    TabStop = false
                };
                pictureBox[currentID].Click += new EventHandler(Picture_Click);

                label[currentID] = new System.Windows.Forms.Label
                {
                    Location = new System.Drawing.Point(m + 19, n + 104),
                    Text = dbMet.GetConnect("name", "products", "id", Convert.ToString(currentID)),
                    Size = new System.Drawing.Size(83, 12)
                };

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