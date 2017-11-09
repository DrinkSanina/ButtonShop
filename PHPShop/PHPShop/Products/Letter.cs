using System;
using System.Drawing;

namespace PHPShop.Products
{
    class Letter : Product
    {
        /// <summary>
        /// Конструктор объекта "Кнопка"
        /// </summary>
        /// <param name="iD">ID товара</param>
        /// <param name="name">Имя товара</param>
        /// <param name="image">Картинка товара</param>
        /// <param name="price">Цена товара</param>
        public Letter(string iD, string name, Image image, decimal price)
        {
            ID = iD;
            Name = name;
            Image = image;
            Price = price;
        }
    }
}
