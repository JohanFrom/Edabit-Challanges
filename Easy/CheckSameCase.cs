using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Check if the Same Case: https://edabit.com/challenge/ivaEWKZbFMcR8emJ8
    public static class CheckSameCase
    {
        public static bool SameCase(string str) => str.ToCharArray().All(x => char.IsLower(x) == true);

    }
}
