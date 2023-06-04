using ProjectEuler.Contracts;

namespace ProjectEuler
{
    public class pe002 : IGet
    {
        public void Get()
        {
            Console.WriteLine("2 - Even Fibonnacci numbers");

            Dictionary<int, long> map = new Dictionary<int, long>();
            map.Add(1, 1);
            map.Add(2, 2);
            int i = 3;
            while (true)
            {
                long currentFib = map[i - 1] + map[i - 2];
                if (currentFib >= 4000000)
                    break;
                if (!map.ContainsKey(i))
                    map.Add(i, map[i - 1] + map[i - 2]);
                i++;
            }
            long sum = 0;
            foreach (var item in map)
            {
                if (item.Value % 2 == 0)
                    sum += item.Value;
            }
            Console.WriteLine(sum);
        }
    }
}