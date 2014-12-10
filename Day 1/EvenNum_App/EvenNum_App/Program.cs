using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace EvenNum_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
             
            Console.WriteLine("Even number from 1 to 100 :");
                for (i = 0; i <= 100; i++)
                {
                    if (i%2 == 0)
                    {
                        Console.WriteLine(+i);
                    }
                }
            Console.ReadLine();
        }
    }
}
