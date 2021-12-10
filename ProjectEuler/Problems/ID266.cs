using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{

//The divisors of 12 are: 1,2,3,4,6 and 12.
//The largest divisor of 12 that does not exceed the square root of 12 is 3.
//We shall call the largest divisor of an integer n that does not exceed the square root of n the pseudo square root(PSR) of n.
//It can be seen that PSR(3102)=47.
//Let p be the product of the primes below 190.
//Find PSR(p) mod 1016.

    internal class ID266
    {
        public void Start()
        {
            Console.WriteLine("The divisors of 12 are: 1,2,3,4,6 and 12.\n" +
                "The largest divisor of 12 that does not exceed the square root of 12 is 3.\n" +
                "We shall call the largest divisor of an integer n that does not exceed the square root of n the pseudo square root(PSR) of n.\n" +
                "It can be seen that PSR(3102)=47.\n" +
                "Let p be the product of the primes below 190.\n" +
                "Find PSR(p) mod 10^16.\n" +
                "Press any key to start...");
            _ = Console.ReadKey();

            double p = Maths.ProductOfPrimesBelow(190);
            double mod = Math.Pow(10,16);
            Console.WriteLine(PseudoSquareRoot(p) % mod);
            //Console.WriteLine(PseudoSquareRoot(3102));
        }

        public double PseudoSquareRoot(double p)
        {
            double checkedNumbers = 0;
            double psrLimit = Math.Sqrt(p);
            double divisor = Math.Floor(psrLimit);
            double lowerLimit = divisor - (p % divisor);
            while(p % divisor != 0)
            {
                divisor--;
                checkedNumbers++;
            }
            return divisor;
        }
    }
}
