using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Closest Palindrome Number: https://edabit.com/challenge/hzRbu3khRaNyoARrw
    public static class ClosestPalindromeNumber
    {
        public static int ClosestPalindrome(int num)
        {
            if (IsPalindrome(num)) return num;

            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(num - i)) return num - i;
                if (IsPalindrome(num + i)) return num + i;
            }

            return 0;
        }

        private static bool IsPalindrome(int num)
        {
            int r, sum = 0, t;
            for (t = num; num != 0; num /= 10)
            {
                r = num % 10;
                sum = sum * 10 + r;
            }

            return t == sum;
        }
    }
}
