using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Reverse Coding Challenge #6: https://edabit.com/challenge/NRAbyiQP9ZNa4bDRT
    public static class ReverseCodingChallengeSix
    {
        public static int MysteryFunc(int num)
        {
            int counter = num == 1 ? 0 : 1;
            foreach (var n in num.ToString().ToCharArray())
            {
                counter *= int.Parse(n.ToString());
            }

            return counter;
        }
    }
}
