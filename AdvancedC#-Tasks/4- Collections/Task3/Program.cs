using static System.Formats.Asn1.AsnWriter;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using System.Xml;

namespace Task3
{
    internal class Program
    {
        //Assignment 3: Using HashSet<T> for Unique Values
        //1.Create a HashSet<string> to store unique programming languages.
        //2.Add the following:
        //"C#"
        //"Java"
        //"Python"
        //"C++"
        //"C#"
        //"Java"
        //3.Print all elements to verify duplicates are not stored.
        //4.Check if "JavaScript" exists in the set.
        //5.Remove "Python" from the set and print the updated values.

        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("C#");
            set.Add("Java");
            set.Add("Python");
            set.Add("C++");
            set.Add("C#");
            set.Add("Java");

            foreach(string s in set)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("------------------------------");

            if(set.Contains("JavaScript")) Console.WriteLine("JavaScript is exist");
            else Console.WriteLine("JavaScript is not exist");

            Console.WriteLine("------------------------------");

            set.Remove("Python");

            foreach (string s in set)
            {
                Console.WriteLine(s);
            }

        }
    }
}
