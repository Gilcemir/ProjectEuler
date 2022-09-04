using System.Numerics;

namespace Project;
//for this algorithm check https://github.com/Gilcemir/DynamicProgramming/tree/master/Fibonacci
public class pe025 : IGet
{
    private static BigInteger[][] baseFibonacci = new BigInteger[][]{
        new BigInteger[]{1, 1},
        new BigInteger[]{1, 0}
    };
    public void Get()
    {
        var fib = LogN(0);
        int i = 1;
        while (fib.ToString().Length < 1000 )
        {
            fib = LogN(i++);
        }

        Console.WriteLine(i - 1);
    }
    public static BigInteger LogN(int n) => n < 2 ? n :
        NthMatrix(baseFibonacci, n - 1)[0][0];
    private static BigInteger[][] NthMatrix(BigInteger[][] matrix, int pot)
    {
        if(pot == 0) //
        {
            return new BigInteger[][]{ //Identity matrix. 
                new BigInteger[]{1, 0},
                new BigInteger[]{0, 1}
            };
        }
        if(pot == 1)
        {
            return matrix;
        }
        BigInteger[][] halfMatrix = NthMatrix(matrix, pot/2);
        BigInteger[][] result = MatrixMultiplier(halfMatrix, halfMatrix);
        if(pot % 2 ==0)
        {
            return result;
        }else
        {
            return MatrixMultiplier(matrix, result);
        }
    }
    private static BigInteger[][] MatrixMultiplier(BigInteger[][] a, BigInteger[][] b)
    {
        BigInteger[][] ans = new BigInteger[][]
        {
            new BigInteger[]{0, 0},
            new BigInteger[]{0, 0}
        };

        ans[0][0] = a[0][0] * b[0][0] + a[0][1] * b[1][0];
        ans[0][1] = a[0][0] * b[0][1] + a[0][1] * b[1][1];
        ans[1][0] = a[1][0] * b[0][0] + a[1][1] * b[1][0];
        ans[1][1] = a[1][0] * b[0][1] + a[1][1] * b[1][1];

        return ans;
    }
}