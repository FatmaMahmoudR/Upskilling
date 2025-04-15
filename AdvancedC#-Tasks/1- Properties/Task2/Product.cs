using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Product
    {
        private double price;
        private int stockQuantity;
        private bool isAvailable;
        public string Name { get; set; }
        public double Price { 
            get { return price; } 
            set {
                if (value > 0)
                {
                    price = value;
                    Console.WriteLine($"Price   : {price}");
                }
                else Console.WriteLine("inalid price value"); 
            }
        }
        public int StockQuantity {
            get { return stockQuantity; }
            set
            {
                if (value >= 0)
                    stockQuantity = value;
                else Console.WriteLine("inalid quantity value");

            }
        }
        public bool IsAvailable
        {
            get
            {
                return StockQuantity > 0;
            }
        }

        public void UpdateStock(int quantity)
        {
            if (quantity < 0) //-
            {
                if(Math.Abs(quantity) <= StockQuantity)
                {
                    StockQuantity += quantity;
                    Console.Write($"{quantity*-1} items are removed");

                }
                else
                {
                    Console.Write("There is not enough items");
                }
                
            }
            else //+
            {
                StockQuantity += quantity;
                Console.Write($"{quantity} items are added");
            }

            Console.WriteLine($"   <<{StockQuantity} items available>>");
            
        }

    }
}
