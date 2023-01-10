using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Reverse the Odd Length Words: https://edabit.com/challenge/yYfQoo6rkMezauG77
    public static class ReverseTheOddLengthWords
    {
        public static string ReverseOdd(string str)
        {
            if (str == string.Empty)
            {
                return string.Empty;
            }

            string[] splittedStr = str.Split(" ");

            if (splittedStr.Length == 1)
            {
                return splittedStr[0].Length % 2 != 0 ? ReverseString(splittedStr[0]) : splittedStr[0];
            }

            for (int i = 0; i < splittedStr.Length; i++)
            {
                splittedStr[i] = splittedStr[i].Length % 2 != 0 ? ReverseString(splittedStr[i]) : splittedStr[i];
            }

            return string.Join(" ", splittedStr);
        }

        private static string ReverseString(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
