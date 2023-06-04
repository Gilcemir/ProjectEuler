using System.Numerics;
using ProjectEuler.Contracts;

namespace ProjectEuler
{
    public class pe020 : IGet
    {
        public void Get()
        {
        var ans = Factorial(100).ToString().Select(x => int.Parse(x.ToString())).Sum();
        Console.WriteLine(ans);
        }
        public static BigInteger Factorial(int n) => n == 1? 1: n* Factorial(n -1);

    }
}