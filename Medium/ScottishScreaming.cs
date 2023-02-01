using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Scottish Screaming: https://edabit.com/challenge/fcGARuJW6tcYyWMQw
    public static class ScottishScreaming
    {
        public static string ToScottishScreaming(string str)
        {
            StringBuilder sb = new();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    sb.Append(' ');
                else if (_vowels.Contains(str[i].ToString().ToUpper()))
                    sb.Append('E');
                else
                    sb.Append(char.ToUpper(str[i]));
            }
            return sb.ToString();
        }

        private static readonly HashSet<string> _vowels = new(StringComparer.InvariantCultureIgnoreCase)
        {
            "A",
            "E",
            "I",
            "O",
            "U"
        };
    }
}
