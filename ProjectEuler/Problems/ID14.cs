using System;
using System.Collections.Generic;
using System.Text;

/* Problem 14 - Longest Collatz Sequence:
 * The following iterative sequence is defined for the set of positive integers:
 * n → n/2 (n is even)
 * n → 3n + 1 (n is odd)
 * Using the rule above and starting with 13, we generate the following sequence:
 * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
 * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
 * Which starting number, under one million, produces the longest chain?
 * NOTE: Once the chain starts the terms are allowed to go above one million.
 */

namespace ProjectEuler.Problems
{
    class ID14
    {
        public void Start()
        {
            Console.WriteLine("Problem 14 - Longest Collatz Sequence:" +
                "The following iterative sequence is defined for the set of positive integers:\n" +
                "n → n/2 (n is even)\n" +
                "n → 3n + 1 (n is odd)\n" +
                "Which starting number, under one million, produces the longest chain?\n" +
                "Press any key to start...\n");
            Console.ReadKey();
            DateTime startTime = DateTime.UtcNow;
            int longestChain = 1, longestStartingNum = 1, chain;
            long collatzNum;
            Dictionary<long, int> map = new Dictionary<long, int>();
            for (int count = 1; count < 1000000; count++)
            {
                chain = 1;
                collatzNum = count;
                do
                {
                    if (map.ContainsKey(collatzNum))
                    { chain += map[collatzNum] - 1; break; }
                    collatzNum = Collatz(collatzNum);
                    chain++;
                }
                while (collatzNum != 1);
                if(!map.ContainsKey(count))
                    {map.Add(count, chain);}
                if(chain > longestChain)
                    { longestChain = chain; longestStartingNum = count; }
            }
            var elapsed = DateTime.UtcNow - startTime;
            Console.WriteLine($"Solution took {elapsed.TotalSeconds} seconds.");
            Console.WriteLine($"{longestStartingNum} has the longest chain, with {longestChain} terms.");
        }

        private long Collatz(long x)
        {
            long result;

            if (x % 2 == 0)
            { result = x / 2; }
            else
            { result = 3 * x + 1; }

            return result;
        }
    }
}
