using System;
using System.Collections.Generic;
using System.Text;

/* Problem 7 - 10001st Prime:
 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
 * What is the 10 001st prime number?
 */

namespace ProjectEuler.Problems
{
    class ID7
    {
        public void Start()
        {
            Console.WriteLine("Problem 7 - 10001st Prime:\n" +
                "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.\n" +
                "What is the 10001st prime number?\n" +
                "Press any key to start...\n");
            Console.ReadKey();

            int targetPrime = 10001;
            int primeCounter = 0;
            long prime = 0;
            while (primeCounter < targetPrime)
            {
                prime += 1;
                if (Maths.IsPrime(prime))
                {
                    primeCounter += 1;
                }
            }

            Console.WriteLine($"The {targetPrime} prime is: {prime}\n");
        }
    }
}
