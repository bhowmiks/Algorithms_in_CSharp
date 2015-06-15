using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fibonacci
{
    public static class fib
    {
        
        public static void fibon(int v)
        {
            for (int j = 0; j< v; j++){
            int a=0, b=1;
            for (int i = 0; i < j; i++)
            {
                int t = a;
                a = b;
                b = a + t;
                
            }
                Console.WriteLine(a);
        }
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            fib.fibon(15);
        }
        
    }
}
