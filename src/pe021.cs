namespace Project
{
    public class pe021 : IGet
    {
        static int n = 10001;
        public void Get()
        {
        int[] d = Enumerable.Range(0, n).Select((x, index) => Divisors(index).Sum()).ToArray();
        Dictionary<int, int> map = new Dictionary<int, int>();
        HashSet<int> amicables = new HashSet<int>();
        
        for(int i = 0; i < d.Length; i++)
        {
            if(d[i] < n && d[i] != 1)
                map[i] = d[i];
        }
       
        foreach(var item in map)
        {
            if(map.ContainsKey(item.Value))
            {
                if(map[item.Value] == item.Key && item.Key != item.Value)
                {
                    amicables.Add(item.Value);
                    amicables.Add(item.Key);
                }
            }
        }
        Console.WriteLine(amicables.Sum());
        }
            public static List<int> Divisors(int n)
    {
        HashSet<int> ans = new HashSet<int>();
        ans.Add(1);
        for(int i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n%i == 0)
            {
                ans.Add(i);
                ans.Add(n/i);
            }
        }
        return ans.ToList();
    }

    }
}