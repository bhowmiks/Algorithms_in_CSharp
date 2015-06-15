using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paliandrome
{
    public  class pal
    {
       

        public void reverseray(string take)
        {
          bool t = true;
          string[] th = take.Split(' ');
        
         
        var y = 0;
            for (int i =th.Length; i>0; i= i-1)
            {
                
                
                if (th[i-1] != th[y])
                {
                    t = false;
                    break;
                }

                
                y++;
               
            }

            if (t == true)
                Console.WriteLine(" A Paliandrome !!");

            else
                Console.WriteLine("NOT a paliandrome");

           
         }
}

    class Program
    {
        static void Main(string[] args)

        {
            pal pal = new pal();
         

             pal.reverseray("oppo oo oppo");

        }
    }
}
