using System;
namespace Project
{
    public class pe004
    {
        static int lowerLimit = 100;
        static int upperLimit = 999;
        public static void Get()
        {
            Console.WriteLine("4 - Largest Palindrome product");
            int largestPalindrome = 0;
            for (int i = upperLimit; i >= lowerLimit; i--)
            {
                for (int j = i; j >= lowerLimit; j--)
                {
                    int candidate = i * j;
                    if (IsPalindrome(candidate))
                    {
                        if (candidate > largestPalindrome)
                            largestPalindrome = candidate;
                    }
                }
            }
            Console.WriteLine(largestPalindrome);

        }
        static bool IsPalindrome(int number)
        {
            string numString = number.ToString();
            int len = numString.Length;
            for (int i = 0; i < len / 2; i++)
            {
                if (numString[i] != numString[len - 1 - i])
                    return false;
            }
            return true;
        }
    }
}