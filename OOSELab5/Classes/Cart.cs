using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSELab5.Classes
{
    //A Cart is basically a bill. It has purchased products and relatives calcs
    public class Cart
    {
        //This is to hold all of the generated bills
        public static List<Cart> bills = new List<Cart>();

        public static int ID = 123;
        public int bill_id;
        public List<Product> products_purchased=new List<Product>();
        public DateTime GeneratedOn { get; }
        public double Discount { get; set; }
        public int TotalItems { get; }
        public double SubTotal { get; set; }
        public double Total { get; }
        public Cart(List<Product> list,double subtotal, double discount)
        {
            bill_id = ID;
            this.products_purchased = list;
            this.TotalItems = list.Count;
            this.SubTotal = subtotal;
            this.Discount = discount;
            this.Total = subtotal - discount;
            GeneratedOn = DateTime.Now;
            ID++;
        }
    }
}
