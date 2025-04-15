namespace Task1
{
    internal class Program
    {
        static void findByIdAndUpdate(List<Student>students,int id, double newGrade)
        {
            bool found = false;
            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    s.Grade = newGrade;
                    Console.WriteLine($"Updated data: [ID:{s.Id} | Name:{s.Name} | Grade:{s.Grade}]");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("the ID is not exist");
            }

        }

        static void Display(List<Student> students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine($"ID:{s.Id} | Name:{s.Name} | Grade:{s.Grade}");
            }
        }

        static void top(List<Student>students, int n)
        {

            if (n > students.Count)
            {
                Console.WriteLine($"Cannot find top {n}, number of studens is {students.Count}");
                return;
            }

            Console.WriteLine($"top {n} students");
            students.Sort();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"ID:{students[i].Id} | Name:{students[i].Name} | Grade:{students[i].Grade}");
            }
            return;

        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "std1", 80));
            students.Add(new Student(2, "std2", 90));
            students.Add(new Student(3, "std3", 70));
            students.Add(new Student(4, "std4", 50));
            students.Add(new Student(5, "std5", 100));

            Display(students);

            Console.WriteLine("----------------------------------");

            findByIdAndUpdate(students, 40, 90);
            findByIdAndUpdate(students, 4, 90);

            Console.WriteLine("----------------------------------");

            int index = 3;
            Student std = students[index];
            students.RemoveAt(index);
            Console.WriteLine($"student with id = {std.Id} is Removed");
            Display(students);


            Console.WriteLine("----------------------------------");

            students.Sort();
            Display(students);

            Console.WriteLine("----------------------------------");

            top(students, 3);
            top(students, 5);

        }
    }
}
