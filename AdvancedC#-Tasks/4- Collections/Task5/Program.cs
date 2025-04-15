using System.Collections;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> tickets = new Queue<string>();

            tickets.Enqueue("Ticket#1");
            tickets.Enqueue("Ticket#2");
            tickets.Enqueue("Ticket#3");
            tickets.Enqueue("Ticket#4");

            tickets.Dequeue();
            tickets.Dequeue();

            foreach(string t in tickets)
            {
                Console.WriteLine(t);
            }
            
        }
    }
}
