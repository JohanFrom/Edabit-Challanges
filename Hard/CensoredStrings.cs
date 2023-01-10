using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // C*ns*r*d Str*ngs: https://edabit.com/challenge/wunaXvZw3WctYioeC
    public static class CensoredStrings
    {
        public static string Uncensor(string txt, string vowels)
        {
            if(txt != string.Empty && vowels == string.Empty) return txt;
            if(txt == string.Empty && vowels != string.Empty) return txt;

            if(txt.Count(c => (c== '*')) != vowels.Length)
            {
                throw new Exception("The voweles must be the same length as censored starts");
            }

            StringBuilder sb = new();
            int cur = 0;

            for (int i = 0; i < txt.Length; i++)
            {
                sb.Append(txt[i] == '*' ? vowels[cur++] : txt[i]);

            }
            return sb.ToString();
        }
    }
}
