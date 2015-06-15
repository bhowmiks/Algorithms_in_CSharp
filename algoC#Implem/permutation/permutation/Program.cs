using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to permute");
            var theString = Console.ReadLine();

            // Get the items.
            string[] items = theString.Split(' ');

            // Generate the permutations.
            var SW1 = new Stopwatch();
            var SW2 = new Stopwatch();
            SW1.Start();
            List<List<string>> results =
                GeneratePermutations<string>(items.ToList());
            int count = 0;
            SW1.Stop();
            // Display the results.
            //results.Items.Clear();
            SW2.Start();
            foreach (List<string> combination in results)
            {
                string builtit = " ";
                StringBuilder createdS = new StringBuilder();
                foreach (var item in combination)
                {


                    createdS.Append(" " + item);
                    // builtit = builtit+ " "+ item;

                }
                count++;
                Console.WriteLine(createdS.ToString());
            }
            SW2.Stop();
            Console.WriteLine("Count {0}", count);
            Console.WriteLine("Comutation time: {0}", SW1.ElapsedMilliseconds);
            Console.WriteLine("Printing   time: {0}", SW2.ElapsedMilliseconds);
            Console.ReadLine();
        }





        // Generate permutations.
        private static List<List<T>> GeneratePermutations<T>(List<T> items)
        {
            // Make an array to hold the
            // permutation we are building.
            T[] current_permutation = new T[items.Count];

            // Make an array to tell whether
            // an item is in the current selection.
            bool[] in_selection = new bool[items.Count];

            // Make a result list.
            List<List<T>> results = new List<List<T>>();

            // Build the combinations recursively.
            PermuteItems<T>(items, in_selection,
                current_permutation, results, 0);

            // Return the results.
            return results;
        }


        // Recursively permute the items that are
        // not yet in the current selection.
        private static void PermuteItems<T>(List<T> items, bool[] in_selection,
            T[] current_permutation, List<List<T>> results,
            int next_position)
        {
            // See if all of the positions are filled.
            if (next_position == items.Count)
            {
                // All of the positioned are filled.
                // Save this permutation.
                results.Add(current_permutation.ToList());
            }
            else
            {
                // Try options for the next position.
                for (int i = 0; i < items.Count; i++)
                {
                    if (!in_selection[i])
                    {
                        // Add this item to the current permutation.
                        in_selection[i] = true;
                        current_permutation[next_position] = items[i];

                        // Recursively fill the remaining positions.
                        PermuteItems<T>(items, in_selection,
                            current_permutation, results,
                            next_position + 1);

                        // Remove the item from the current permutation.
                        in_selection[i] = false;
                    }
                }
            }//end else

        }//end PermuteItems



    }
}
