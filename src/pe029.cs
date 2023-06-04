using System.Numerics;
using ProjectEuler.Contracts;

namespace ProjectEuler;

public class pe029 : IGet
{
    private const int _lowerLimit = 2;
    private const int _upperLimit = 100;
    private readonly HashSet<BigInteger> map = new HashSet<BigInteger>();
    public void Get()
    {
        for(BigInteger a = _lowerLimit; a <= _upperLimit; a++)
        {
            for(int b = _lowerLimit; b <= _upperLimit; b++)
            {
                map.Add(BigInteger.Pow(a, b));
            }
        }
        System.Console.WriteLine(map.Count);
    }
}
