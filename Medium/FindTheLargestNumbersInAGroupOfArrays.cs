using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Find the Largest Numbers in a Group of Arrays: https://edabit.com/challenge/nermqxzovZbfFBC9X
    public static class FindTheLargestNumbersInAGroupOfArrays
    {
        public static double[] FindLargest(double[][] values) => values.Select(x => x.Max()).ToArray();
    }
}
