using System.Numerics;
using ProjectEuler.Contracts;

//no need explanation for this one. Very easy using brute force.

namespace ProjectEuler
{
    public class pe016 : IGet
    {
        public void Get()
        {
            Console.WriteLine(Sum(2));
        }
        //Crivo de Erastóstenes - Project Euler 7 

        public static int Sum(BigInteger n) => BigInteger.Pow(n, 1000)
                                        .ToString()
                                        .Aggregate(0, (sum, next) => sum += int.Parse(next.ToString()));
    }
}