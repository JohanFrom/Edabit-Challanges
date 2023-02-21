using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Among Us Imposter Formula: https://edabit.com/challenge/kjeS389wuyQ4Y4vZa
    public static class AmongUsImposterFormula
    {
        public static string ImposterFormula(int i, int p) => $"{(100 * (double)i / (double)p)}%";
    }
}
