using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.Problems
{
    class Maths
    {
        public static bool IsPrime(long number)
        {
            if (number == 2) { return true; }
            else if (number < 2) { return false; }
            for (long x = 2; x < number; x++)
            {

                if (x * x > number) { break; }
                if (number % x == 0)
                { return false; }
            }
            return true;
        }

        public static double ProductOfPrimesBelow(long targetNum)
        {
            double product = 1;
            double prime = 0;
            while (prime < targetNum)
            {
                prime += 1;
                if (Maths.IsPrime((long)prime))
                {
                    product *= prime;
                }
            }
            return product;
        }
    }
}
