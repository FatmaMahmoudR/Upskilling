namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cache<int, string> cache = new Cache<int, string>(3);

            cache.Add(100, "cache1");
            cache.Add(101, "cache2");
            cache.Add(102, "cache3");
            cache.printCache();

            cache.Add(103, "cache4");
            cache.printCache();

            cache.Add(104, "cache5");
            cache.printCache();

            cache.Remove(101);
            cache.Remove(102);

            cache.printCache();
            Console.WriteLine(cache.Retrieve(103));
            Console.WriteLine(cache.Retrieve(102));





        }
    }
}
