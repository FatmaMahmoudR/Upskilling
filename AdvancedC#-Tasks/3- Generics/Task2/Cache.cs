using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Cache<TKey, TValue>
    {
        Dictionary<TKey, TValue> cache;
        List<TKey> queue;
        int size;
        int count;

        public Cache(int n)
        {
            cache = new Dictionary<TKey, TValue>();
            queue = new List<TKey>();
            size = n;
            count = 0;
        }
        
        public void Add(TKey key, TValue value)
        {
            if (count < size)
            {
                queue.Add(key);
                cache.Add(key, value);
                count++;
            }
            else
            {
                TKey least_used_item = queue[0];

                queue.Remove(least_used_item);
                queue.Add(key);

                cache.Remove(least_used_item);
                cache.Add(key, value);
            }
        }

        public void Remove(TKey key)
        {
            bool removed = cache.Remove(key);
            if (removed)
            {
                queue.Remove(key);
                count--;
                Console.WriteLine($"{key} is removed ");
            }else
                Console.WriteLine($"the item with key = {key} is not found");

        }

        public TValue Retrieve(TKey key)
        {
            if (cache.TryGetValue(key, out TValue value))
                return value;

            Console.WriteLine($"The item with key = {key} is not found");
            return default(TValue); 
        }

        public void printCache()
        {
            foreach(var it in cache)
            {
                Console.Write($"[{it.Key}|{it.Value}] ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------");

        }




    }
}
