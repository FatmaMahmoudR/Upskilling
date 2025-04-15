namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 5, 9 };
            Employee[] employees = { new Employee(101, 5000), new Employee(102, 8000), new Employee(103, 3000)};

            //----------- 1 -----------

            ArrayUtils.ReverseArray(ref arr);

            foreach(var it in arr)
                Console.Write($"{it} ");
            Console.WriteLine();


            ArrayUtils.ReverseArray(ref employees);

            foreach (var it in employees)
                Console.Write($"{it} ");
            Console.WriteLine();

            //----------- 2 -----------

            Console.WriteLine(ArrayUtils.FindMax(arr, Comparer<int>.Default));
            Console.WriteLine(ArrayUtils.FindMax(employees, new EmpComparer())); 

        }
    }
}
