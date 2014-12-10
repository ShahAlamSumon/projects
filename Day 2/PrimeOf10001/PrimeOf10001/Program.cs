using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOf10001
{
    class Program
    {
       static void Main(string[] args)
        {
            
           int count = 6;
           int tergetcount = 10001;
           long x;

           for (x = 13 + 2; count <= tergetcount; x += 2)
           {
               if (IsPrime(x))
               {
                   count++;
               }
           }
           Console.WriteLine(x);
           Console.ReadLine();
        }
       static bool IsPrime(Int64 p)
       {
           if (p % 2 == 0) return false;
           Int64 max = (Int64)Math.Ceiling(Math.Sqrt(p));
           for (Int64 divisor = 3; divisor < max; divisor += 2)
           {
               if (p % divisor == 0) return false;
           }
           return true;
       }
    }
    }

