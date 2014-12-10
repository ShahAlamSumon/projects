using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplisOf_3_5_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            for (i = 0; i <= 1000; i++)
            {
                if((i%3==0))
                {
                    sum = sum + i;
                }
                if (i%5==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
