using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 51, 34, 3, 23 };
            var upper = arr.Length;

            int min, temp;
            for (int outer = 0; outer < upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <upper; inner++)
                    if (arr[inner] < arr[min])
                        min = inner;
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}

