using System;
using System.Windows.Forms;

namespace PHPShop.AssortmentEngine
{
    class AssortmentLoad
    {
        const String pictureVault = "http://localhost/pictures/"; //Путь к папке с картинками на сервере
        DatabaseMethods dbMet = new DatabaseMethods();
        

        /// <summary>
        /// Метод загрузки динамического ассортимента. Расписан подробно при реализации.
        /// </summary>
        /// <param name="panel">Панель на форме</param>
        /// <param name="Picture_Click">Обработчик событий по нажатию на pictureBox</param>
        public AssortmentLoad(Panel panel, EventHandler Picture_Click)
        {
            int m = 0; //Начальная x-коориданата на панели
            int n = 5; //Начальная y-координата на панели
            int lastID = dbMet.GetMaxConnect("max(id)", "products"); //Получаем последний индекс товара из БД
            PictureBox[] pictureBox = new PictureBox[lastID + 1]; //Создаем коллекцию из pictureBox с заданным ранее количеством (lastID - 1, тк нет товара с нулевым ID)
            Label[] label = new Label[lastID + 1]; //То же самое, но для меток
            for (int currentID = 1; currentID < pictureBox.Length; currentID++) 
            {
                pictureBox[currentID] = new System.Windows.Forms.PictureBox(); //Создаем pictureBox
                pictureBox[currentID].Location = new System.Drawing.Point(m, n); //Позиция - точка с текущими x и y-коорлдинатами
                pictureBox[currentID].Size = new System.Drawing.Size(100, 100); //Задаем размер
                pictureBox[currentID].Name = Convert.ToString(currentID); //Присваиваем имя
                String path = pictureVault + dbMet.GetConnect("picture", "products", "id", Convert.ToString(currentID)); //Тут начинается мясо. Тк, картинка находится на сервере, то нам достаточно указать до нее путь, заданный раннее в pictureVault + название нужной картинки из БД
                pictureBox[currentID].ImageLocation = path; //Задаем картинку по пути
                pictureBox[currentID].Click += new EventHandler(Picture_Click); //Задаем событие по нажатию на pictureBox
                //Аналогично поступем с label-ами
                label[currentID] = new System.Windows.Forms.Label();
                label[currentID].Location = new System.Drawing.Point(m + 19, n + 104);
                label[currentID].Text = dbMet.GetConnect("name", "products", "id", Convert.ToString(currentID));
                label[currentID].Size = new System.Drawing.Size(83, 12);
                //Добавляем элементы на панель
                panel.Controls.Add(pictureBox[currentID]);
                panel.Controls.Add(label[currentID]);
                m = m + 110; //Делаем ряд из элементов

                if (currentID % 5 == 0) //Смотрим, сколько элементов уже в ряду, и если оно будет кратно максимальному числу элементов в ряду, то...
                {
                    m = 0;      //Обнулить x-координату
                    n += 150;   //Увеличить y-координату, сделав отступ вниз
                }
            }
        }
    }
   
}