using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Reverse and Capitalize: https://edabit.com/challenge/rMGErLnrGdDXWZJF5
    public static class ReverseAndCapitalize
    {
        public static string ReverseCapitalize(string str) => string.Concat(str.ToCharArray().Reverse().Select(x => char.ToUpper(x)));
    }
}
