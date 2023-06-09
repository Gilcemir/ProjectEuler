using System.Collections.Specialized;
using System.Numerics;
using System.Text;
using ProjectEuler.Contracts;
using static System.Console;

namespace ProjectEuler;

public class pe031 : IGet
{
    public void Get()
    {
        int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200};
        int target = 200;

        int result = SolveMemo(coins, target);

        WriteLine(result);
    }

    private static int SolveMemo(int[] nums, int target)
    {
        var dict = nums.ToDictionary(x => x, i => 0);
        IDictionary<int, HashSet<string>> memo = new Dictionary<int, HashSet<string>>();
        
        Solve(nums, target, memo, dict);
        
        return memo[0].Count;
    }

    private static void Solve(int[] nums, int target, IDictionary<int, HashSet<string>> memo, IDictionary<int ,int> dict)
    {
        if (target < 0)
            return;
        var stringKey = KeyGenerator(dict);
        if (memo.TryGetValue(target, out _) && memo[target].TryGetValue(stringKey, out _))
        {
            return;
        }
        if(memo.TryGetValue(target, out var value))
        {
            value.Add(stringKey);
        }

        if (!memo.TryGetValue(target, out _))
        {
            memo[target] = new HashSet<string>();
            memo[target].Add(stringKey);
        }

        foreach (var num in nums)
        {
            var remainder = target - num;
            dict[num]++;
            Solve(nums, remainder, memo, dict);
            dict[num]--;
        }
    }
    
    private static string KeyGenerator(IDictionary<int, int> dict)
    {
        if (dict == null || dict.Count == 0)
            return "";

        var result = new StringBuilder();

        foreach (var kv in dict)
        {
            result.Append($"{kv.Key}={kv.Value},");
        }

        return result.ToString();
    }
}