using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Year = 2019;
            car.Mileage = 100;
            car.Drive(15);
            Console.WriteLine(car.Mileage);
            Console.WriteLine(car.Age);

            Console.ReadKey();
        }
    }
}
