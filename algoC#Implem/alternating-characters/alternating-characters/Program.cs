using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace alternating_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int element = int.Parse(Console.ReadLine());
            List<int> record = new List<int>();

            string[] inputs = new string[element];

            List<string> result = new List<string>();
            for (int i = 0; i < element; i++)
            {
                inputs[i] = Console.ReadLine();

            }

            foreach (var item in inputs)
            {
                record.Add(DelCount(item));
            }

            foreach (var item in record)
            {
                Console.WriteLine(item);
            }


        }

       static  int DelCount(string input)
        {
            int count = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if(input[i-1]==input[i])
                {
                    count++;
                
                }
                
            }

            return count;
        
        
        }
    }
}
