using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c=1;
            Console.WriteLine(+a);
            Console.WriteLine(+b);
            

            for (int i=0;i<=100; i++)
            {
                c = a + b;
                if (c>=100)
                {
                    break;
                }
                
                
                Console.WriteLine( +c);
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}
