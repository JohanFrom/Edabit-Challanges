using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Profitable Gamble: https://edabit.com/challenge/ipGXGwbJ3e8aBEu3r
    public static class ProfitableGamble
    {
        public static bool Gamble(double prob, int prize, double pay) => (prob * prize) > pay;
    }
}
