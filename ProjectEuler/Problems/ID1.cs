using System;
using System.Collections.Generic;
using System.Text;

/* Problem 1 - Multiples of 3 and 5:
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 */

namespace ProjectEuler.Problems
{
    class ID1
    {
        public void Start()
        {
            Console.WriteLine("Problem 1 - Multiples of 3 and 5:\n" +
                "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.\n" +
                "Find the sum of all the multiples of 3 or 5 below 1000.\n" +
                "Enter a number:\n");
            int number;
            if(int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine($"\nResult for {number}: {SumMultiples(number)}");
            }
            else
            {
                Console.WriteLine("\nInvalid number entry.\n");
                return;
            }
        }
        public int SumMultiples(int below)
        {
            int sum = 0;
            for (int i = 0; i < below; i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
