namespace Project;

public class pe023 : IGet
{
    private static int _limit = 28123;
    public void Get()
    {
        var set = SumOfAbundants();
        // return abundant numbers which is not mapped in the previous method
        long result = Enumerable.Range(1, _limit).Where(x => !set.Contains(x)).Sum();
        Console.WriteLine(result);
    }

    //Prime factorization
    private static Dictionary<int, int> GetPrimes(int n)
    {
        var primes = new Dictionary<int, int>();
        int divisor = 2;
        
        while (n > 1)
        {
            while (n % divisor == 0)
            {
                if(!primes.ContainsKey(divisor))
                    primes.Add(divisor, 0);

                primes[divisor]++;
                n = n / divisor;
            }

            divisor++;
        }
        return primes;
    }

    //return sum of primes (in the given context)
    private static int SumOfPrimeFactors(int n)
    {
        var primes = GetPrimes(n);
        int sum = 1;
        foreach (var item in primes)
        {
            int denominador = (int)Math.Pow(item.Key, item.Value + 1) - 1;
            int divisor = item.Key - 1;

            sum *= denominador / divisor;
        }
        //n not included
        return sum - n;
    }

    //map all the abundant numbers
    private static HashSet<int> AbundantNumbers()
    {
        var set = new HashSet<int>();
        for (int i = 1; i < _limit; i++)
        {
            if (i < SumOfPrimeFactors(i))
                set.Add(i);
        }
        return set;
    }
    
    //sum abundant numbers
    private static HashSet<int> SumOfAbundants()
    {
        var set = new HashSet<int>();
        var abundants = AbundantNumbers().ToList();
    
        for(int i = 0; i < abundants.Count; i++)
        {
            for (int j = i; j < abundants.Count; j++)
            {
                var sum = abundants[i] + abundants[j];
                if (sum > _limit)
                    break;
                set.Add(sum);
            }
        }
        return set;
    }
}