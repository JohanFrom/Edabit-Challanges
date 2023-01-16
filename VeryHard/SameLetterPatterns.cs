using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Same Letter Patterns: https://edabit.com/challenge/QpSMWmb8AoTdtrBQZ
    public static class SameLetterPatterns
    {
        public static bool SameLetterPattern(string str1, string str2)
        {
            return MapString(str1) == MapString(str2);
        }

        private static string MapString(string input)
        {
            Dictionary<char, int> seen = new();
            int index = 0;
            return string.Join(string.Empty,
              input.Select(c => seen.ContainsKey(c) ? seen[c] : seen[c] = index++));
        }
    }
}
