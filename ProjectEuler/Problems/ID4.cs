using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Problem 4 - Largest Palindrome Product
 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
 * Find the largest palindrome made from the product of two 3-digit numbers.
 */
namespace ProjectEuler.Problems
{
    class ID4
    {
        public void Start()
        {
            Console.WriteLine("Problem 4 - Largest Palindrome Product\n" +
                "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.\n" +
                "Find the largest palindrome made from the product of two 3-digit numbers.\n" +
                "Press any key to start...\n");
            Console.ReadKey();

            int result = 0;
            for(int x = 100; x < 1000; x++)
            {
                for (int y = 100; y < 1000; y ++)
                {
                    int mult = x * y;
                    if(IsPalindrome(mult) & mult > result)
                    {
                        result = mult;
                    }
                }
            }
            Console.WriteLine($"\nResult: {result}");
        }

        private bool IsPalindrome(int number)
        {
            string numString = number.ToString();
            string reverseString = "";
            for (int i = numString.Length - 1; i >=0; i--)
            {
                reverseString += numString[i];
            }
            int reverseNum = int.Parse(reverseString);
            
            if(number == reverseNum)
            { return true; }
            else { return false; }
        }
    }
}
