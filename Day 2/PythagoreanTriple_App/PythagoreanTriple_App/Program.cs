using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriple_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1000;
            for (int a = 1; a <= total; a++)
            {
                for (int b = 1; b <= total; b++)
                {
                    int c = total - a - b;
                    int res = (a * a) + (b * b) + (c * c);
                    int r = a + b + c;

                    int left = (a * a) + (b * b);
                    int right = (c * c);

                    if (left == right && a < b && b < c)
                    {
                        Console.WriteLine("a="+a + "  b= " + b + "  c= " + c);
                        //Console.WriteLine("a="+Math.Pow(a, 2) + "  b=" + Math.Pow(b, 2) + "  c=" + Math.Pow(c, 2));
                        Console.WriteLine("Product of a,b,c = " + a * b * c);
                        Console.WriteLine("---------------------");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
