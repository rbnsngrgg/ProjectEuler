using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

/* Problem 9 - Special Pythagorean Triplet:
 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a^2 + b^2 = c^2
 * For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2
 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
 * Find the product abc.
 */

namespace ProjectEuler.Problems
{
    class ID9
    {
        public void Start()
        {
            Console.WriteLine("Problem 9 - Special Pythagorean Triplet:\n" +
                "A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a^2 + b^2 = c^2\n" +
                "For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2\n" +
                "There exists exactly one Pythagorean triplet for which a + b + c = 1000.\n" +
                "Find the product abc.\n" +
                "Press any key to start...\n");
            Console.ReadKey();
            int a, b, c;
            for(a = 1; a < 998;a++)
            {
                for(b = a+1; b < 998; b++)
                {
                    for(c = b+1; c < 998; c++)
                    {
                        if(((a < b)& (b < c)) & (a+b+c == 1000) & IsTriplet(a,b,c))
                        {
                            Console.WriteLine($"{a} x {b} x {c} = {a*b*c}");
                            return;
                        }
                    }
                }
            }
        }

        private bool IsTriplet(int a, int b, int c)
        {
            if((a*a)+(b*b)==(c*c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
