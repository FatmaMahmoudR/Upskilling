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
            Car c = new Car();
            c.Describe();

            Motorcycle m = new Motorcycle();
            m.Describe();

            Truck t = new Truck();
            t.Describe();

            Console.ReadKey();
        }
    }
}
