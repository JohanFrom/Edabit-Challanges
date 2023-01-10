using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // The Collatz Conjecture: https://edabit.com/challenge/F6m5ZRyzK5fmqTrBG
    public static class TheCollatzConjecture
    {
        public static int Collatz(int num) => num == 1 ? 0 : num % 2 == 0 ? 1 + Collatz(num / 2) : 1 + Collatz(3 * num + 1);
        
    }
}
