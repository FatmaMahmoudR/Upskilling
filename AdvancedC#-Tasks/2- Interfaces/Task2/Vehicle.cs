using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal abstract class Vehicle
    {
        public void Start() { 
            Console.WriteLine("started"); 
        }
        public void Stop() { 
            Console.WriteLine("stopped"); 
        }
        public abstract void Describe();

    }
}
