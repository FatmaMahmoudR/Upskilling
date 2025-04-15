using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        public int CompareTo(Object obj)
        {
            Student s = obj as Student;
            if (s == null) return 1;
            return s.Grade.CompareTo(this.Grade);
        }
    }
}
