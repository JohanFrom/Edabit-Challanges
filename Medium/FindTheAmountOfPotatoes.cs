using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Find the Amount of Potatoes: https://edabit.com/challenge/u6HAot7ojYFTSm9aZ
    public static class FindTheAmountOfPotatoes
    {
        public static int Potatoes(string str)
        {
            Regex rx = new("potato");
            MatchCollection matches = rx.Matches(str);
            return matches.Count;
        }
    }
}
