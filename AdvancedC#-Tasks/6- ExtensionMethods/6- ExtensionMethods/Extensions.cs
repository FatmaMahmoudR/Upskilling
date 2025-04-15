using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace _6__ExtensionMethods
{
    static class Extensions
    {
        public static int GetAge(this DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            return age;
        }


        public static double AverageEvenNumbers(this List<int> numbers)
        {
            double res=0;
            int cnt = 0;
            
            foreach(int it in numbers){
                if (it % 2 == 0)
                {
                    res += it;
                    cnt++;
                }
            }

            res /= cnt;
            return res;
        }

        public static IEnumerable<T> Paginate<T>(this IEnumerable<T> source, int page, int pageSize)
        {

            int start = (page - 1) * pageSize,end = start + pageSize;
            int i = 0;
            foreach (var it in source)
            {
                if (i >= start && i < end)
                    yield return it;
                if (i >= end)
                    yield break;
                i++;
            }
        }


        public static string ToJson<T>(this T obj)
        {
            return JsonSerializer.Serialize(obj);
        }

    }
}
