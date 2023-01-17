using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Repeating Letters N Times: https://edabit.com/challenge/Lmhmtj3QZw9cF5Zew
    public static class RepeatingLettersNTimes
    {
        public static string Repeat(string str, int num)
        {
            StringBuilder sb = new();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(str[i], num);
            }

            return sb.ToString();
        }
    }
}
