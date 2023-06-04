using ProjectEuler.Contracts;

namespace ProjectEuler;

public class pe030 : IGet
{

    private readonly long[] map = new long[]
    {
        0,
        1,
        32,
        243,
        1024,
        3125,
        7776,
        16807,
        32768,
        59049
    };


    public void Get()
    {
        long sum = 0;
        for (long i = 2; i <= 354294; i++)
        {
            var sumOfDigits = GetDigits(i).Sum(x => map[x]);
            if (i == sumOfDigits)
            {
                Console.WriteLine($" --- i = {i} --- ");
                sum += sumOfDigits;
            }
        }

        Console.WriteLine(sum);
    }

    private static long[] GetDigits(long source)
        => GetDigits1(source).Reverse().ToArray();

    private static IEnumerable<long> GetDigits1(long source)
    {
        while (source > 0)
        {
            var digit = source % 10;
            source /= 10;
            yield return digit;
        }
    }
}
