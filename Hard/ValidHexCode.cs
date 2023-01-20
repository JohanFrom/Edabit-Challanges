using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Valid Hex Code: https://edabit.com/challenge/8tyXtHqAT3LAuHMqu
    public static class ValidHexCode
    {
        public static bool IsValidHexCode(string hexCode)
        {
            if (hexCode[0] != '#') return false;
            if (hexCode[1..].Length != 6) return false;

            for (int i = 1; i < hexCode.Length; i++)
            {
                if (!_validChars.Contains(hexCode[i].ToString()))
                    return false;
            }
            
            return true;
        }

        private static readonly HashSet<string> _validChars = new(StringComparer.InvariantCultureIgnoreCase)
        {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
        };
    }
}
