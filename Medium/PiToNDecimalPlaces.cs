using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Pi to N Decimal Places: https://edabit.com/challenge/uz6HACQLjH9DE6HcP
    public static class PiToNDecimalPlaces
    {
        public static decimal MyPi(int num) => (decimal)Math.Round(Math.PI, num);
    }
}
