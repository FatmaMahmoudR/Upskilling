namespace Task6
{
    internal class Program
    {

        static void Add(Dictionary<int, HashSet<string>> dict, int id, string subject)
        {
            if (!dict.ContainsKey(id))
                dict[id] = new HashSet<string>();

            dict[id].Add(subject);
        }

        static void Remove(Dictionary<int, HashSet<string>> dict, int id, string subject)
        {
            if (dict.ContainsKey(id) && dict[id].Contains(subject))
            {
                dict[id].Remove(subject);
                Console.WriteLine($"{subject} is Removed from StudentID: {id}");
            }
            else
            {
                Console.WriteLine($"{subject} is not found for StudentID: {id}");
            }
        }

        static void Print(Dictionary<int, HashSet<string>> dict, int id)
        {
            if (dict.ContainsKey(id))
            {
                Console.Write($"StudentID: {id} |");

                foreach (string subject in dict[id])
                {
                    Console.Write($" {subject} ");
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine($"ID: {id} is not found.");
        }

        static void Main(string[] args)
        {
            Dictionary<int, HashSet<string>> dict = new Dictionary<int, HashSet<string>>();

            
            Add(dict, 1, "subject1");
            Add(dict, 1, "subject2");
            Add(dict, 1, "subject3"); 
            Add(dict, 1, "subject1"); 

            Add(dict, 2, "subject1");
            Add(dict, 2, "subject2");

            Add(dict, 3, "subject1");
            Add(dict, 3, "subject2");

            
            Print(dict, 1);

            Remove(dict, 1, "subject2");
            Print(dict, 1);
        }
    }
}
