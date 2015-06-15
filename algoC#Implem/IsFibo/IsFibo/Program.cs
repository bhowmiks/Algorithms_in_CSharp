using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsFibo
{
    class Program
    {

               static public List<int>  fibon(int v)
        {
                    List<int> allFibon = new List<int>();

            for (int j = 0; j< v; j++){
            int a=0, b=1;
            for (int i = 0; i < j; i++)
            {
                int t = a;
                a = b;
                b = a + t;
                
            }
                
                allFibon.Add(a);
        }
                    return allFibon;
                         
        }
    

        static void Main(string[] args)
        {
           List<int> allFibon = new List<int>();
            List<string> fibResults = new List<string>();
           allFibon = fibon(50);
           int element = int.Parse(Console.ReadLine());

          
           string[] inputs = new string[element];
           long[] allInput = new long[inputs.Length];

           for (int i = 0; i < element; i++)
           {
               allInput[i] = long.Parse(Console.ReadLine());


           }
           

            foreach (var item in allInput)
	{
                var isPresent= InSeries(allFibon, item);

                if(isPresent)
                {
                  fibResults.Add("IsFibo");
                
                }
                else
                {
                fibResults.Add("IsNotFibo");
                }
		 
	}

            foreach (var item in fibResults)
	{
                Console.WriteLine(item);
		 
	}



        }


static public bool InSeries(List<int> fibSeries, long Num)
{
    if (fibSeries.Exists(x=> x==Num))
    {
        return true;

    
    }

    return false;
}


    }
}

