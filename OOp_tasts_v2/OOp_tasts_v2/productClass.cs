using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOp_tasts_v2
{
    public class productClass
    {
        private string name;
        private decimal price;
        private int stock;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set 
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Cannot be negative,defined as 0.");
                }
            }
        }
        public int Stock
        {
            get { return stock; }
            set
            {
                if (value > 0)
                {
                    stock = value;
                }
                else 
                {
                    Console.WriteLine("Cannot be negative,defined as 0.");
                }
            }
        }
        public productClass(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }
        public void GetInfo()
        {
            Console.WriteLine(@$"Product name: {name}
Price: {price}$
Stock: {stock}");
        }
    }
}
