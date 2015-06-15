using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SliceMethod
{
  public static class sliceray
  {
      public static t[] sliceit<t>(t[] source, int start, int end)
      { 
          int len=  end-start;
          t[] buf = new t[len];
          for(int i= 0; i<len; i++)
          {
              buf[i] = source[i + start];
          }
          return buf;
      }
  }

    class Program
    {
        static void Main(string[] args)
        {
            string[] ty = new string[] { "w", "a", "s", "S", "u", "p" };
            
            var e= ( sliceray.sliceit(ty,3,ty.Length));


            foreach (var pw in e)
            {
                Console.WriteLine(pw);
            }
        }
    }
}
