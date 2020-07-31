using System;
using System.Collections.Generic;
using System.Text;

/* Problem 10 - Summation of Primes:
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * Find the sum of all the primes below two million.
 */

namespace ProjectEuler.Problems
{
    class ID10
    {
        public void Start()
        {
            Console.WriteLine("Problem 10 - Summation of Primes:\n" +
                "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.\n" +
                "Find the sum of all the primes below two million.\n" +
                "Press any key to start...\n");
            Console.ReadKey();

            long sumPrimes = 0;
            int below = 2000000;
            for(int i = 2; i < below; i++)
            {
                if(Maths.IsPrime(i))
                {
                    sumPrimes += i;
                }
            }
            Console.WriteLine($"\nThe sum of the primes below {below} is {sumPrimes}.");
        }
    }
}
