using System;
using System.Collections.Generic;
using System.Text;

/* Problem 6 - Sum Square Difference:
 * The sum of the squares of the first ten natural numbers is, 1^2+2^2+...+10^2 = 385
 * The square of the sum of the first ten natural numbers is, (1+2+...+10)^2 = 55^2 = 3025
 * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640
 * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */
namespace ProjectEuler.Problems
{
    class ID6
    {
        public void Start()
        {
            Console.WriteLine("Problem 6 - Sum Square Difference:\n" +
                "The sum of the squares of the first ten natural numbers is, 1^2+2^2+...+10^2 = 385\n" +
                "The square of the sum of the first ten natural numbers is, (1+2+...+10)^2 = 55^2 = 3025\n" +
                "Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640\n" +
                "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.\n" +
                "Press any key to start...\n");
            Console.ReadKey();

            long sumOfSquares = SumSquares(100);
            long squaredSum = SquareSum(100);
            Console.WriteLine($"\nSum of Squares: {sumOfSquares}\nSquare of sum: {squaredSum}\nResult: {squaredSum - sumOfSquares}\n");
        }
        private long SumSquares(int upTo)
        {
            long result = 0;
            for(int i = 1; i <= upTo;i++)
            {
                result += i*i;
            }
            return result;
        }
        private long SquareSum(int upTo)
        {
            long result = 0;
            for(int i = 0; i <= upTo; i++)
            {
                result += i;
            }
            result *= result;
            return result;
        }
    }
}
