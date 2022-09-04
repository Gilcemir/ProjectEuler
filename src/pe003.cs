using System;
namespace Project
{
    public class pe003 : IGet
    {
        static long num = 600851475143;
        public void Get()
        {
            Console.WriteLine("3 - Largest Prime Factor");

            long prime = 1;
            for (long i = 2; i < Math.Sqrt(num); i++) //iterate until sqrt num, to find the last prime_number which divide num
                if (IsPrime(i) && num % i == 0)
                {
                    prime = i;
                }
            Console.WriteLine(prime);
        }
        static bool IsPrime(long number)
        { //check if number is a prime
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;

        }
    }
}