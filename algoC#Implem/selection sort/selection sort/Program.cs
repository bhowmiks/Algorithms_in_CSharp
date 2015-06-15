using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {

           // int[] arr = new int[] { 51, 34, 3, 6, 89, 4 };
            int[] arr = new int[] { 4, 3, 7, 1};
            var upper = arr.Length;

            int min, temp;
            for (int outer = 0; outer < upper; outer++)
            {
                Console.WriteLine("............................");
                min = outer;
                for (int inner = outer + 1; inner < upper; inner++)
                {
                    Console.WriteLine("min:{0}", min);
                    if (arr[inner] < arr[min])
                        min = inner;
                    

                }
                Console.WriteLine("min:{0}", min);
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;


                             for (int i = 0; i < arr.Length; i++)
                             {

                                 Console.WriteLine(arr[i]);
                                 


                             }
            }
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i]);

            }


        }



    }
}
