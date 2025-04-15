using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Employee
    {
        public int ID { get; set; }
        public int Salary { get; set; }

        public Employee ( int iD, int salary)
        {
            ID = iD;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return $" << ID: {ID}, Salary: {Salary} >>";
        }
    }
}
