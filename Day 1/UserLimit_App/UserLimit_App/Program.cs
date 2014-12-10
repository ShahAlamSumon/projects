using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLimit_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter largest number :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter higest number :");
            y = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Numbers are :");
            if (x < y)
            {
                for (int i = x; i <= y; i++)
                {
                    Console.WriteLine(+i);
                }
            }
            else
            {
                for (int j = y; j <= x;j++)
                {
                    Console.WriteLine(+j);
                }
            }
            Console.ReadLine();
        }

    }
}
