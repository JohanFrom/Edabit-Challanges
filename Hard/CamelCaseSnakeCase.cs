using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // camelCase ⇄ snake_case: https://edabit.com/challenge/RBqvKrYLxtM57G5FQ
    public static class CamelCaseSnakeCase
    {
        public static string ToSnakeCase(string str)
        {
            StringBuilder sb = new();
            sb.Append(char.ToLowerInvariant(str[0]));
            for (int i = 1; i < str.Length; ++i)
            {
                if (char.IsUpper(str[i]))
                {
                    sb.Append('_');
                    sb.Append(char.ToLowerInvariant(str[i]));
                }
                else
                {
                    sb.Append(str[i]);
                }
            }

            return sb.ToString();
        }

        public static string ToCamelCase(string str) => 
                str.Split(new[] { "_" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => char.ToUpperInvariant(s[0]) + s[1..])
                .Aggregate(string.Empty, (s1, s2) => s1 + s2);

    }
}
