
/*
some mathematical scratches:
triangle number :
f(0) = 0,
f(1) = 1
f(2) = 1 + 2 = f(1) + 2;
f(3) = 1 + 2 + 3 = f(1) + 2 + 3 = f(2) + 3;
.
.
.
f(n) = f(n-1) + 3;------------

Using memoization...


*/


namespace Project
{
    public class pe012
    {
        static List<long> triangleNumbers;
        public static void Get()
        {
            triangleNumbers = new List<long>();
            triangleNumbers.Add(0);//f(0)
            triangleNumbers.Add(1);//f(1)

            for (int i = 2; i < 12376; i++)
            {
                long nextTringle = triangleNumbers[i - 1] + i;
                triangleNumbers.Add(nextTringle);
                var divs = Divisors(nextTringle);

                if (divs > 500){
                    Console.WriteLine($"n = {i}, f(n) = {nextTringle}, number of divisors = {divs}");
                    Console.WriteLine($"The answer is {nextTringle}");
                    break;
                    }
            }

        }
        public static bool IsPerferctSquare(long number) => (Math.Sqrt(number) % 1 == 0);

        public static int Divisors(long n)
        {
            var count = 0;
            for (int i = 1; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    count += 2;
            }
            if (IsPerferctSquare(n))
                return count + 1;
            return count;
        }
    }
}