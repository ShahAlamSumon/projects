using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compair_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter 1st number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x>y)
            {
                Console.WriteLine("The big number is :" +x);
                Console.WriteLine("The small number is :" +y);
            }
            else if(x==y)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                Console.WriteLine("The big number is : " +y);
                Console.WriteLine("The small number is :" +x);
            }

            Console.ReadLine();
        }
    }
}
