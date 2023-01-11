using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Positive Count / Negative Sum: https://edabit.com/challenge/SXeEZPxDM9Y5HzLvw
    public static class PositiveCountNegativeSum
    {
        public static int[] CountPosSumNeg(double[] arr)
        {
            if(arr.Length == 0)
            {
                return Array.Empty<int>();
            }

            int positiveCount = arr.Where(x => x > 0).Count();
            int negativeSum = (int)arr.Where(x => x < 0).Sum();

            return new int[] { positiveCount, negativeSum };
        }
    }
}
