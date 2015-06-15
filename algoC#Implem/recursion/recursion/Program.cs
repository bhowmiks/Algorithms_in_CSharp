using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace recursion
{
    class Program
    {
        static int fact(int value)
        {

            Console.WriteLine(value);
            if (value <=1)
                return value;

         else
             
           return value* fact(value-1);

           
        }

        static void Main()
        {
            int y= fact(3);
            Console.WriteLine(y);

        }
        
    }
}
