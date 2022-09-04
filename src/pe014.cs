/*
    Approach:
    Use dynamic programming/MEMOIZATION to store paths that we already calculated;

*/

namespace Project
{
    public class pe014 : IGet
    {
        static Dictionary<long, long> map;
        public void Get()
        {
            map = new Dictionary<long, long>();
            map.Add(1, 1);

            long longestChain = 0;
            long number = 0;
            for (long i = 1; i <= 1000000; i++)
            {
                long temp = CountCollatz(i);
                if (longestChain < temp)
                {
                    longestChain = temp;
                    number = i;
                }
            }

            Console.WriteLine(longestChain);
            Console.WriteLine("The answer is : " + number);
        }

        static public long CountCollatz(long n)
        {
            if (map.ContainsKey(n))
                return map[n];

            long num = n;
            long count = 0;
            while (num != 1)
            {
                count++;
                num = Collatz(num);
                if (map.ContainsKey(num))
                {
                    count += map[num];
                    break;
                }
            }
            map.Add(n, count);

            return count;
        }

        static public long Collatz(long n) => n % 2 == 0 ? n / 2 : n * 3 + 1;
    }

}