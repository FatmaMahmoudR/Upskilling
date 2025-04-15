using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    class ArrayUtils
    {
        public static void ReverseArray<T>(ref T[] array)
        {
            int n = array.Length;
            T[] arr = new T[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = array[n - i - 1];
            }
            array = arr;

        }
        

        public static T FindMax<T>(T[] arr, IComparer<T> comparer)
        {
            T max = arr[0];

            foreach(var it in arr)
            {
                if (comparer.Compare(it,max) > 0)
                {
                    max = it;
                }
            }

            return max;
             
        }


    }
}
