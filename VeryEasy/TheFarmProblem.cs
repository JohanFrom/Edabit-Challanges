using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // The Farm Problem: https://edabit.com/challenge/4AaTbg5NuA8eSijcr
    public static class TheFarmProblem
    {
        public static int Animals(int chickens, int cows, int pigs) => (chickens * 2) + (cows * 2) + (pigs * 2);
    }
}
