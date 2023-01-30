using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Longest Common Ending: https://edabit.com/challenge/zRNkYPzy8oviqkrWc
    public static class LongestCommonEnding
    {
        public static string CommonEnding(string str1, string str2)
        {
            str1 = string.Join("", str1.Reverse()); ;
            str2 = string.Join("", str2.Reverse());

            StringBuilder sb = new();
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1[i] == str2[i])
                    sb.Append(str2[i]);
            }
            
            return string.Join("", sb.ToString().Reverse());
        }
    }
}
