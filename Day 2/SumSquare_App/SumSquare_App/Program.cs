using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquare_App
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumOfSquares = 0;
            long sum = 0;
            long squareOfSums = 0;

            for (int i = 1; i < 101; i++)
            {   sumOfSquares += i ^ 2; 
                sum += i; 
            }
            squareOfSums = sum * sum;
            Console.WriteLine( "The difference between the sum of the squares and the square of the sums of the first 100 natural numbers is: " +(squareOfSums - sumOfSquares) );

            Console.ReadLine();
        }
    }
}
