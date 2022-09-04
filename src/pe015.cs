/*
    Approach:
    How I solved this not beeing clever:

    1) Found out that for a grid n x n, we have to go down and right n times.
        So if you have a grid with 1 x 1 you have to go right and down 1 time
        same for 2 x 2 etc.

        As long as I walk 2*n steps, with n steps to right and n steps downwards, I will reach the end point.
        So the answer is the number os combinations of R and D steps:

        for a grid 1 x 1:

        R, D
        D, R

        for a grid 2 x 2:
        R, R, D, D
        R, D, R, D
        R, D, D, R
        D, R, R, D
        D, R, D, R
        D, D, R, R etc...

        so I found out the solution up to n = 5 by using one of my LeetCode codes using backtracking.
        So 
        f(1) = 2;
        f(2) = 6
        f(3) = 20
        f(4) = 70
        f(5) = 252

        up to f(6) my computer was not able to calculate.
        So I googled those number in order and found out the pattern, which is:

        f(n) = (2n)!/(n!)^2


        In our case, we need te result for n = 20...

        f(20) = (2*20)!/(20! * 20!)
        Lets code...

        CHECK FULL ANALYSIS HERE:
        https://github.com/Gilcemir/DynamicProgramming/tree/master/GridTraveler
*/

using System.Numerics;

namespace Project
{
    public class pe015 : IGet
    {
        public void Get()
        {
            BigInteger nFac = Fatorial(20);
            BigInteger ans = Fatorial(2*20)/(nFac*nFac);

            Console.Write(ans);
        }

        public static BigInteger Fatorial(BigInteger n) => n == 1 ? 1 : n*Fatorial(n -1);
    }
}