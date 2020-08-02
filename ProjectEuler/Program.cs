using System;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--------------------------------------------------\n" +
                    "Project Euler Solution Repository\n" +
                    "1.  Multiples of 3 and 5\n" +
                    "2.  Even Fibonacci Numbers\n" +
                    "3.  Largest Prime Factor\n" +
                    "4.  Largest Palindrome Product\n" +
                    "5.  Smallest Multiple\n" +
                    "6.  Sum Square Difference\n" +
                    "7.  10001st Prime\n" +
                    "8.  Largest Product in a Series\n" +
                    "9.  Special Pythagorean Triplet\n" +
                    "10. Summation of Primes\n" +
                    "11. Largest Product in a Grid\n" +
                    "12. Highly Divisible Triangular Number\n" +
                    "13. Large Sum\n" +
                    "14. Longest Collatz Sequence\n" +
                    "\nType \"exit\" to exit.\n");

                string selection = Console.ReadLine();
                if(selection.ToLower() == "exit")
                {
                    break;
                }
                else
                {
                    MenuSelection(selection);
                }
            }
        }

        static void MenuSelection(string selection)
        {
            switch (selection)
            {
                case "1":
                    {
                        var problem = new ID1();
                        problem.Start();
                        break;
                    }
                case "2":
                    {
                        var problem = new ID2();
                        problem.Start();
                        break;
                    }
                case "3":
                    {
                        var problem = new ID3();
                        problem.Start();
                        break;
                    }
                case "4":
                    {
                        var problem = new ID4();
                        problem.Start();
                        break;
                    }
                case "5":
                    {
                        var problem = new ID5();
                        problem.Start();
                        break;
                    }
                case "6":
                    {
                        var problem = new ID6();
                        problem.Start();
                        break;
                    }
                case "7":
                    {
                        var problem = new ID7();
                        problem.Start();
                        break;
                    }
                case "8":
                    {
                        var problem = new ID8();
                        problem.Start();
                        break;
                    }
                case "9":
                    {
                        var problem = new ID9();
                        problem.Start();
                        break;
                    }
                case "10":
                    {
                        var problem = new ID10();
                        problem.Start();
                        break;
                    }
                case "11":
                    {
                        var problem = new ID11();
                        problem.Start();
                        break;
                    }
                case "12":
                    {
                        var problem = new ID12();
                        problem.Start();
                        break;
                    }
                case "13":
                    {
                        var problem = new ID13();
                        problem.Start();
                        break;
                    }
                case "14":
                    {
                        var problem = new ID14();
                        problem.Start();
                        break;
                    }
                default:
                    break;
            }

        }
    }
}
