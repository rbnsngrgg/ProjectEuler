using System;
using System.Collections.Generic;
using System.Text;
/* Problem 5 - Smallest Multiple:
 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */
namespace ProjectEuler.Problems
{
    class ID5
    {
        public void Start()
        {
            Console.WriteLine("Problem 5 - Smallest Multiple:\n" +
                "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.\n" +
                "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?\n" +
                "Press any key to start...\n");
            Console.ReadKey();
            Console.WriteLine($"\n{SmallestMult()}");
        }

        private int SmallestMult()
        {
            int result=0;
            int bottom = 1, top = 20;

            for(int x = top; x < int.MaxValue; x++)
            {
                bool isValid = true;
                for (int y = bottom; y <= top; y++)
                {
                    if (!(x%y==0))
                    { isValid = false; break; }
                }
                if(isValid)
                {
                    result = x;
                    return result;
                }
            }
            return result;
        }
    }
}
