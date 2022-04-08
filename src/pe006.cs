using System;
using System.Linq;

namespace Project
{
    public class p006
    {
        public static void Get()
        {
            Console.WriteLine("6 - Sum square difference");

            Console.WriteLine("\nBrute force ");

            //Brute Force
            int sum = Enumerable.Range(1, 100).Sum();
            int sumSquares = Enumerable.Range(1, 100).Select(x => x * x).Sum();

            Console.WriteLine(sum * sum - sumSquares);

            Console.WriteLine("\nFormula ");

            //not brute force
            int n = 100;
            int sum2 = n * (n + 1) / 2; //formula for n f(n) = n*(n-1)/2

            int sumSquares2 = n * (2 * n + 1) * (n + 1) / 6; //formula f(n) = n(2n+1)(n+1)/6; according to project euler.
            Console.WriteLine(sum2 * sum2 - sumSquares2);
        }
    }
}
