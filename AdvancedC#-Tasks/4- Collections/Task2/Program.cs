using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.Collections;
using System.Diagnostics.Metrics;
using System;

namespace Task2
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "USA");
            dict.Add(91, "India");
            dict.Add(44, "UK");
            dict.Add(81, "Japan");
            dict.Add(20, "Egypt");

            foreach(KeyValuePair<int,string> entry in dict)
            {
                Console.WriteLine($"code: {entry.Key} country: {entry.Value}");
            }

            Console.WriteLine("---------------------------------");


            Console.Write("enter a country code: ");
            int code = int.Parse(Console.ReadLine());
            if (dict.ContainsKey(code))
            {
                string name = dict[code];
                Console.WriteLine($"country is {name}");
            }else Console.WriteLine("country is not found");

            Console.WriteLine("---------------------------------");

            
            dict.Remove(91);

            foreach (KeyValuePair<int, string> entry in dict)
            {
                Console.WriteLine($"code: {entry.Key} country: {entry.Value}");
            }

        }
    }
}
