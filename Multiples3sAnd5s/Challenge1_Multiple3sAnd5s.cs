//   12. Solve the lab using the instructions below.
//   a.If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3,5,6, and 9. The sum of these multiples is 23.
//   b. Find the sum of all multiples of 3 or 5 below 1000 and print it out to the console.

namespace CSCodeChallenges
{
	public class Challenge1_Multiple3sAnd5s
	{
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t=-=-=-= CHALLENGES =-=-=-=\n\n");

            #region Sum Below 1000

            Console.WriteLine("1) Find the sum of all multiples of 3 or 5 below 1000");
            int sum = 0;

            for (int nbr = 0; nbr < 1000; nbr++)
            {
                if (nbr % 3 == 0 || nbr % 5 == 0)
                {
                    sum += nbr;
                }
            }
            Console.WriteLine("The sum of all multiples of 3 or 5 below 1000 is: " + sum);

            #endregion

            #region Fibonacci Even Sum

            Console.WriteLine("\n2) Fibonacci Even Sum");

            #endregion

            #region Ten Digit Fibonacci

            Console.WriteLine("\n3) Ten Digit Fibonacci");

            #endregion

            #region Longest Collatz

            Console.WriteLine("\n4) Longest Collatz");

            #endregion
        }

    }
}
