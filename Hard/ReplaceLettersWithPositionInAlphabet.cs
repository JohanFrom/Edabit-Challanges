using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Replace Letters With Position In Alphabet: https://edabit.com/challenge/v2czrbq3acTMSGbEe
    public static class ReplaceLettersWithPositionInAlphabet
    {
        public static string AlphabetIndex(string str)
        {
            Dictionary<int, string> dict = new();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                dict[c - 64] = c.ToString();
            }

            StringBuilder sb = new();
            char[] chars = str.ToUpper().ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (dict.ContainsValue(chars[i].ToString()))
                {
                    sb.Append(dict.FirstOrDefault(x => x.Value == chars[i].ToString()).Key + " ");
                }
            }
            return sb.ToString().TrimEnd();
        }
    }
}
