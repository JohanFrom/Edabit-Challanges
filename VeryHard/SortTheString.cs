using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Sort the String: https://edabit.com/challenge/ZLM2e2d3ATvjzkxT7
    public static class SortTheString
    {
        public static string Sorting(string str)
        {
            var sortedWords = ToStringArray(str).OrderBy(x => x, StringComparer.InvariantCulture);
            string sortedStr = String.Join("", sortedWords);

            StringBuilder sb = new();
            foreach (var c in sortedStr.ToCharArray())
            {
                if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
            }

            sortedStr = Regex.Replace(sortedStr, "[0-9]", "");
            return sortedStr + sb.ToString(); 
        }

        //internal static bool ContainsDuplicate(IOrderedEnumerable<string> arr)
        //{
        //    return arr
        //   .GroupBy(p => p.ToLower())
        //   .Where(g => g.Count() > 1)
        //   .Select(g => g.Key).Count() > 0;
     
        //}

        internal static IEnumerable<string> ToStringArray(string str)
        {
            string[] strArray = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                yield return strArray[i] = str[i].ToString();
            }
        }
    }
}
