using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3sAnd5s
{
    internal class FibonacciEvenSum
    {
        static void Main(string[] args)
        {
            int maxNumber = 4000000;
            Console.WriteLine("Find sum of all even numbers in the Fibonacci sequence that are under four million. (4,000,000)");
            Console.WriteLine($"{ FindFibonacciSumUnder(maxNumber) }");
        }

        static int FindFibonacciSumUnder(int maxNumber)
        {
            int a = 0;
            int b = 1;
            int sum = 0;

            while (b < maxNumber)
            {
                if (b % 2 == 0)
                {
                    sum += b;
                }
                
                sum = a + b;
                a = b;
                b = sum;

                
                
            };

            return sum;



        }

    }
}
