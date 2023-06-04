using ProjectEuler.Contracts;

/*
        Approach:
            Build a dictionary with every prime number that is needed to generate a certain range of numbers.
            key will store the Prime number, value will store the number of times we need that prime to generate 
            For example:
    for 1 to 10:
    key = 2 (3)
    key = 3 (2)
    key = 5 (1)
    key = 7 (1)
    2*2*2*3*3*5*7 = 2520.
    
    With those numbers we can genrate every number in the range:
    2 = 2
    3 = 3
    4 = 2*2
    5 = 5
    6 = 2*3
    7 = 7
    8 = 2*2*2
    9 = 3*3
    

    Easier to solve that without coding at all :D
    */

namespace ProjectEuler
{
    public class pe005 : IGet
    {
        public void Get()
        {
            Console.WriteLine("5 - Smallest multiple");

            Dictionary<int, int> primes = new Dictionary<int, int>();

            //from 1 to 20.
            for (int num = 2; num <= 20; num++)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();
                int i = 2;
                int number = num;
                while (number != 1)
                {
                    map.Add(i, 0);
                    while (number % i == 0)
                    {
                        map[i]++;
                        number /= i;
                    }
                    if (map[i] == 0)
                    {
                        map.Remove(i);
                    }
                    i++;
                }
                foreach (var item in map)
                {
                    if (primes.ContainsKey(item.Key))
                    {
                        if (item.Value > primes[item.Key])
                            primes[item.Key] = item.Value;
                    }
                    else
                    {
                        primes.Add(item.Key, item.Value);
                    }

                }
            }
            foreach (var item in primes)
            {
                Console.WriteLine($"Prime = {item.Key} ({item.Value})");
            }
            Console.WriteLine("2**4 * 3**2 * 5 * 7 * 11 * 13 * 17 * 19  = 232792560");
            Console.WriteLine("where x**y means Math.Pow(x, y)");
        }
    }
}