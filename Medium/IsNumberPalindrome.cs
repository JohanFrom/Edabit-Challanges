using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Check if a Number is a Palindrome: https://edabit.com/challenge/qrJyh8ouvr2iseZy4
    public static class IsNumberPalindrome
    {
        public static bool IsPalindrome(int num) => string.Join("", num.ToString().ToCharArray().Reverse()) == num.ToString();
    }
}
