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
                    "1. Multiples of 3 and 5\n" +
                    "2. Even Fibonacci Numbers\n" +
                    "3. Largest Prime Factor\n" +
                    "4. Largest Palindrome Product\n" +
                    "5. Smallest Multiple\n" +
                    "6. Exit\n");

                string selection = Console.ReadLine();
                if(selection == "6")
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
                default:
                    break;

            }

        }
    }
}
