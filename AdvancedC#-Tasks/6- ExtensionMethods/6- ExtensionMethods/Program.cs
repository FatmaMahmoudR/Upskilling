using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6__ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime BD = new DateTime(2008,02,29);
            Console.WriteLine(BD.GetAge());


            Console.WriteLine($"------------------");


            List<int> list = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};
            Console.WriteLine(list.AverageEvenNumbers());


            Console.WriteLine($"------------------");

            var numbers = new List<int>();
            for (int i = 1; i <= 160; i++)
                numbers.Add(i);

            foreach (var number in numbers.Paginate(2,10))
                Console.WriteLine(number);
            

            Console.WriteLine($"------------------");


            var e = new {ID=10, Name="Emp1" };

            Console.WriteLine(e.ToJson());
        }
    }
}
