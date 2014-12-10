using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Shah";
            //string lastName = "Alam";

            //int noOfFTFLs = 119;

            

            //string fullname = firstName + " " + lastName;

            //Console.WriteLine(fullname);
            //Console.WriteLine(noOfFTFLs);

            int a = 100;
            long b = a;

            
            double i = 19;
            double result = GetSquare(i);
            Console.WriteLine(result);
            
            Console.ReadLine();
        }

        private static double GetSquare(double aValue)
        {
            double squareValue = aValue*aValue;
            return squareValue;
        }
    }
}
