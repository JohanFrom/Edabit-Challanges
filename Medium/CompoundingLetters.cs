using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Compounding Letters: https://edabit.com/challenge/djCa8yiv5kYPhvcAZ
    public static class CompoundingLetters
    {
        public static string Accum(string str)
        {
            StringBuilder sb = new();
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                sb.Append(char.ToUpper(str[i]));
                sb.Append(new string(str[i], i) + "-");
            }
            sb.Length += -1;
            return sb.ToString();
            
        }
    }
}
