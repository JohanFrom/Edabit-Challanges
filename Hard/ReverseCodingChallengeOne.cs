using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Reverse Coding Challenge #1: https://edabit.com/challenge/bqveyPRgcWZM7XzMQ
    public static class ReverseCodingChallengeOne
    {
        public static string MysteryFunc(string str)
        {
            StringBuilder sb = new();
            for (int i = 0; i < str.Length; i++)
            {
                sb.AppendFormat("{0}{1}", str[i], (i & 1) == 0 ? "" : " ");
            }

            string[] splittedStr = sb.ToString().Trim().Split(" ");
            sb.Clear();

            for (int i = 0; i < splittedStr.Length; i++)
            {
                char[] chars = splittedStr[i].ToCharArray();
                sb.Append(chars[0], int.Parse(chars[1].ToString()));
            }

            return sb.ToString();   
        }
    }
}
