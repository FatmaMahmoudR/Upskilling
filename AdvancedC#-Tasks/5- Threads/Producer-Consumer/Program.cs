using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Threading;
using System.Net.Sockets;
namespace Producer_Consumer
{
    internal class Program
    {

        static Queue<int> buffer = new Queue<int>();

        static object locker = new object();


        static void producer(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Thread.Sleep(200);

                lock (locker)
                {
                    buffer.Enqueue(i * i);
                    Console.WriteLine($" {i*i} Added ");
                }
            }
        }

        static void consumer(int n)
        {
             
            for (int i = 0; i < n; i++)
            {
                Thread.Sleep(200);

                lock (locker)
                {
                    if (buffer.Count > 0)
                    {
                        int x = buffer.Dequeue();
                        Console.WriteLine($" {x} Removed ");
                    }else
                    {
                        Console.WriteLine("Queue is empty, waiting for items to be added ");
                    }
                }
            }
        }
        static void Main(string[] args)
   
        {
            Thread producerT = new Thread(() => producer(15));
            Thread consumerT = new Thread(() => consumer(17));

            producerT.Start();
            consumerT.Start();

        }


    }
}
