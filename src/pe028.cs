using System.Numerics;

namespace Project;

/*
The ideia behind this exercise is very simple.
for a grid n*n, we have n*n numbers in it.
Everytime you complete a spiral, the last number of the sequence will be the n^2 of the grid. 
For n = 3, the most right upper value will be 9.
For n = 5, 49 and so forth.

For n = 1001, the right upper corner will be 1001^2.

Now we need to calculate the other three corners left.

For this we will walk all the way back, anti-clockwise.

foreach corner we reach, the value of that corner will be (value of the last corner) - (n -1), because the last corner is placed in the same line or column as well.

Now lets implement it.

*/
public class pe028 : IGet
{
    private const int _limit = 1001;
    public void Get()
    {
        //for n = 1 the formula will fail, so we add up manually. Lazy programming technique
        long result = 1;
        
        for(int i = 3; i <= _limit; i+=2)
        {
            result += SumOfCorners(i);
        }
        System.Console.WriteLine(result);
    }

    public static long SumOfCorners(int n)
    {
        long[] corners = new long[4];

        corners[0] = n*n;
        corners[1] = corners[0] - (n - 1);
        corners[2] = corners[1] - (n - 1);
        corners[3] = corners[2] - (n - 1);

        long result = 0;
        foreach(var corner in corners)
        {     
            result += corner;
        }
        return result;
    }
}