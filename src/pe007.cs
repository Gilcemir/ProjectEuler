using System;
using System.Linq;

namespace Project
{
    public class pe007
    {
        public static void Get()
        {
            Console.WriteLine("10001st prime");

            Dictionary<int, long> map = new Dictionary<int, long>();
            map.Add(1, 2);//LAZY PROGRAMMING
            map.Add(2, 3);
            map.Add(3, 5);
            map.Add(4, 7);
            map.Add(5, 11);
            map.Add(6, 13);

            long i = 15;
            int prime = 7;
            while (map.Count <= 10001)
            {
                if (IsPrime(i))
                {
                    map.Add(prime, i);
                    prime++;
                }
                i += 2;//there's no other prime number even besides 2.
            }
            Console.WriteLine("The 10001th prime number is : "+map[10001]);

        }
        static bool IsPrime(long num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
