using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Convert "Zero" and "One" to "1" and "0": https://edabit.com/challenge/yrL3zkSECbde2Dc8i
    public static class ConvertZeroOneTo1and0
    {
        public static string TextToNumberBinary(string textBinary)
        {
            string[] parts = textBinary.Split(" ");
            if (parts.Length < 8) return string.Empty;

            StringBuilder sb = new();
            for (int i = 0; i < 8; i++)
            {
                if (!AllowedStrings.Contains(parts[i])) return string.Empty;

                sb.Append(parts[i].Equals("zero", StringComparison.InvariantCultureIgnoreCase) ? "0" : "1");
            }

            return sb.ToString();
        }

        internal static HashSet<string> AllowedStrings = new(StringComparer.InvariantCultureIgnoreCase)
        {
            "zero",
            "one"
        };

     
    }
}
