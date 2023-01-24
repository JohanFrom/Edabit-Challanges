using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Return the Index of All Capital Letters: https://edabit.com/challenge/6qFnpAhd3kdmYcNG2
    public static class ReturnTheIndexOfAllCapitalLetters
    {
        public static int[] IndexOfCapitals(string str)
        {
            StringBuilder sb = new();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    sb.Append(i + " ");
            }

            sb.Length -= 1;
            return sb.ToString().Split(" ").Select(x => int.Parse(x)).ToArray();
        }
    }
}
