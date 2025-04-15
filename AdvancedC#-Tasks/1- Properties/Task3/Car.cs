using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public void Drive(int distance)
        {
            if (distance > 0)
            {
                Mileage += distance;
                return;
            }
            Console.WriteLine("invalid distance value");
        }


        public int Age
        {
            get
            {
                return DateTime.Now.Year - Year;
            }
        }
         


    }
}
