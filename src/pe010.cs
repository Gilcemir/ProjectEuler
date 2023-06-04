using ProjectEuler.Contracts;

namespace ProjectEuler
{
    public class pe010 : IGet
    {
        public void Get()
        {
            Console.WriteLine("10 - Summation of primes");
            long _limit = 2000000;

            List<long> primes = new List<long>();
            primes.Add(2); //particular case

            for (int i = 3; i < _limit; i += 2)
            {//every prime number besides 2 is odd
                if (IsPrime(i)) primes.Add(i);
            }
            Console.WriteLine(primes.Sum());
        }
        //Crivo de Erastóstenes - Project Euler 7 
        public static bool IsPrime(long n)
        {
            if (n == 3 || n == 2)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;
            if (n < 9)
                return true;
            double limit = Math.Sqrt(n);
            for (int i = 5; i <= limit; i += 6)
            { 
                if (n % i == 0) return false;
                if (n % (i + 2) == 0) return false;
            }
            return true;
        }
    }
}