using System;
using System.Drawing;

namespace PHPShop.Products
{
    public class Product
    {
        public decimal Price { get; set; }
        public String Name { get; set; }
        public Image Image { get; set; }
        public String ID { get; set; }
    }
}
