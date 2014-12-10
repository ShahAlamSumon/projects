using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacci_App
{
    internal class Program
    {
        public class FibonacciEven
        {
             public static void Main(String[] stuff) {
                 
                 int num1 = 1;
                 int num2 = 2;
                 
                 Int64 evenTerms = 2;
                 while (num2 < 4000000)
                 {
                     int temp = num1;
                     num1 = num2;
                     num2 = temp + num2;
                     if (num2 % 2 == 0)
                     {
                         evenTerms += num2;
                     }
                 }
                 Console.WriteLine(evenTerms);
                 Console.ReadLine();
            }
        }

         
    }

    
}
   