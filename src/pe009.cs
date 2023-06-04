using ProjectEuler.Contracts;

namespace ProjectEuler
{
    public class pe009 : IGet
    {
        //Approach: Brute force, with b always starting from a+1, since  a < b < c.

        public void Get()
        {
            Console.WriteLine("9 - Special Pythagorean triplet");
            long ans = 0;

            for (long a = 3; a < 1000; a++)
            {
                for (long b = a + 1; b < 1000; b++)
                {
                    long c = b * b + a * a;
                    c = (long)Math.Sqrt(c);

                    if (a + b + c == 1000 && c * c == a * a + b * b)
                    {
                        ans = (a * b * c);
                        Console.WriteLine($"a = {a}, b = {b}, c = {c} -> {ans}");
                        return;
                    }
                }
            }
        }
    }
}