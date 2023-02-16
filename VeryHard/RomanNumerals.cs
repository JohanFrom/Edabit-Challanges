using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Roman Numerals: https://edabit.com/challenge/vmRJz4CYmJCQ8otuf
    public static class RomanNumerals
    {
        public static int ParseRomanNumeral(string num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int returnNum = _romanNumbersDictionary[num[i]];
                if (i + 1 < num.Length && _romanNumbersDictionary[num[i + 1]] > _romanNumbersDictionary[num[i]])
                    sum -= returnNum;
                else
                    sum += returnNum;
            }
            return sum;

        }

        private static readonly Dictionary<char, int> _romanNumbersDictionary = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
    }
}
