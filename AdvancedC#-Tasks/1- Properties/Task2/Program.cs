using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Name = "Test";
            p.Price = -2;
            p.Price = 50;

            p.StockQuantity = 0;
            Console.WriteLine(p.IsAvailable);
            p.UpdateStock(5);
            p.UpdateStock(-8);
            p.UpdateStock(-2);
            Console.WriteLine(p.IsAvailable);


            Console.ReadKey();
        }
    }
}
