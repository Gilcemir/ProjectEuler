using ProjectEuler.Contracts;

namespace ProjectEuler;

public class pe026 : IGet
{
    private const int limit = 1000;
    public void Get()
    {
        int[] map = new int[1001];
        var longestRecurringCycle = -1;
        var ans = -1;
        for(int i = 2; i <= limit; i++)
        {
            if(!IsDivisible(i))
            {
                var count = Solve(i);
                if(count > longestRecurringCycle)
                {
                    longestRecurringCycle = count;
                    ans = i;
                }
                
            }
        }

        Console.WriteLine(ans);
    }

    private static bool IsDivisible(int divisor) 
    {
        return limit%divisor == 0;
    }
    /// <summary>
    /// Map the remainders of the division, while it exists or repeats.
    /// </summary>
    /// <param name="n">Number to Solve</param>
    /// <returns>The recurrency cycle length</returns>
    private static int Solve(int n)
    {
        var denominator = SetDenominator(n);
        var remainder = denominator%n;
        var mapOfRemainders = new HashSet<int>
        {
            denominator
        };
        
        while(remainder != 0 && !mapOfRemainders.Contains(remainder))
        {
            mapOfRemainders.Add(remainder);
            denominator = SetDenominator(n, remainder);
            remainder = denominator % n;
        }
        return mapOfRemainders.Count;
    }

    /// <summary>
    /// Sets the next denominator. If denominator is less than the number, increases its value
    /// to make sure that the remainder will always be an integer.
    /// </summary>
    /// <param name="n">The divisor</param>
    /// <param name="n">Current remainder</param>
    /// <returns>return the next 10^x greater than n</returns>
    private static int SetDenominator(int n, int denominator = 10) 
    {
        while(denominator < n)
            denominator *= 10;

        return denominator; 
    }
}