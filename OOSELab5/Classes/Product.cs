using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSELab5.Classes
{
    public class Product
    {
        public static List<Product> products = new List<Product>();
        public string Name { get; set; }
        public int Price { get; }
        public int Quantity { get; set; }
        public Product(string name,int price)
        {
            this.Name = name;
            this.Price = price;
        }
        public Product(string name, int price,int qty)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = qty;
        }
    }
}
