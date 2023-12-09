using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3sAnd5s
{
    internal class TenDigitFibonacci
    {
        static void Main()
        {
            int digits = 10;

            Console.WriteLine($"Find the index of the first Fibonacci number with {digits} digits...");

            int result = FindFibonacciWithDigits(digits, out int index);

            Console.WriteLine($"The first Fibonacci number with {digits} digits is {result} at index {index}");
        }

        static int FindFibonacciWithDigits(int targetDigits, out int index)
        {
            int a = 0;
            int b = 1;
            int sum;
            int currentIndex = 1;

            while (CountDigits(b) < targetDigits)
            {
                sum = a + b;
                a = b;
                b = sum;
                currentIndex++;
            }

            index = currentIndex;
            return b;
        }

        static int CountDigits(int number)
        {
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }
    }
}
