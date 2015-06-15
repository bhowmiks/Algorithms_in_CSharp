using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
    public  delegate void edel();

    public class countnums
    {

        public event edel edelevent;

        public  void  printfizz()
        {
            Console.WriteLine("Fizz....");
        
        }
       
        public void printbuzz()
        {
            Console.WriteLine("buzz....");

        }

        public void oncount()
        {
            if(edelevent!= null){
            edelevent();
        }
        }
    
    }


    

    class Program
    {
        static void Main(string[] args)
        {
            countnums theev = new countnums();
            theev.edelevent += theev.printbuzz;

             theev.edelevent += theev.printfizz;
             
          
            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    theev.oncount();
                }
                else
                    Console.WriteLine(i);
                
            }
        }
    }
}

