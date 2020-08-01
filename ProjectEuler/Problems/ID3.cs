using System;
using System.Collections.Generic;
using System.Text;

/* Problem 3 - Largest Prime Factor
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143 ?
 */

namespace ProjectEuler.Problems
{
    class ID3
    {
        public void Start()
        {
            Console.WriteLine("Problem 3 - Largest Prime Factor:\n" +
                "The prime factors of 13195 are 5, 7, 13 and 29.\n" +
                "What is the largest prime factor of the number 600851475143 ?\n" +
                "Press any key to start...\n");
            Console.ReadKey();

            long checkLPF = 600851475143;
            //if(long.TryParse(Console.ReadLine(),out checkLPF))
            {
                Console.WriteLine($"\n{checkLPF} largest prime factor: {largestPrimeFactor(checkLPF)}\n");
            }
        }
        private long largestPrimeFactor(long factorOf)
        {
            long result = 0;

            for(long x = 2; x < Math.Sqrt(factorOf); x++)
            {
                if (!(factorOf%x == 0)){ continue; }
                if (Maths.IsPrime(x))
                {
                    if (x > result)
                    { result = x; }
                }
            }
            return result;
        }
    }
}
