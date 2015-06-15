using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atbash
{
    class Program
    {
        static void Main()
        {
            AtbashTable x = new AtbashTable();

            Console.WriteLine(x.Transform("Sam Allen is awesome."));
            Console.WriteLine(x.Transform(x.Transform("Sam Allen is awesome.")));

            const string s = "hob hold slow holy horn zoo all irk low glow grog";
            Console.WriteLine(x.Transform(s));
            Console.WriteLine(x.Transform(x.Transform(s)));

            Console.Read();
        }
    }

    /// <summary>
    /// Transforms text using Atbash cipher.
    /// </summary>
    class AtbashTable
    {
        /// <summary>
        /// Lookup table to shift characters.
        /// </summary>
        char[] _shift = new char[char.MaxValue];

        /// <summary>
        /// Generates the lookup table.
        /// </summary>
        public AtbashTable()
        {
            // Set these as the same.
            for (int i = 0; i < char.MaxValue; i++)
            {
                _shift[i] = (char)i;
            }
            // Reverse order of capital letters.
            for (char c = 'A'; c <= 'Z'; c++)
            {
                _shift[(int)c] = (char)('Z' + 'A' - c);
            }
            // Reverse order of lowercase letters.
            for (char c = 'a'; c <= 'z'; c++)
            {
                _shift[(int)c] = (char)('z' + 'a' - c);
            }
        }

        /// <summary>
        /// Apply the Atbash cipher.
        /// </summary>
        public string Transform(string value)
        {
            try
            {
                // Convert to char array
                char[] a = value.ToCharArray();
                // Shift each letter.
                for (int i = 0; i < a.Length; i++)  
                {
                    int t = (int)a[i];
                    a[i] = _shift[t];
                    char d = _shift[t];
                }

                return new string(a);
                
                //StringBuilder nn= new StringBuilder("110 'n'");

                //string prr = nn.ToString();

                //char[] ff = new char[13];
                ////ff[1]= "110 'n'";
                //ff = prr.ToCharArray();
                //string fof = new string(a);
                //string kk= a[0].ToString();
                //return new string(ff);


            }
            catch
            {
                // Just return original value on failure.
                return value;
            }
        }
    }
}
