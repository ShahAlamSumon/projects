using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMath_App
{
    class Program
    {
        



        static void Main(string[] args)
        {
            double a, b;
            
            Console.Write("Enter 1st number:  ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Addition :"  +(a+b));
            Console.WriteLine("Subtruction :"  +(a-b));
            Console.WriteLine("Multiplication :"  +(a*b));
            Console.WriteLine("Divition :"  +(a/b));



            Console.ReadLine();


        }
    }
}
