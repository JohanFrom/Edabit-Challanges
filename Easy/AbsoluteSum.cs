using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Absolute Sum: https://edabit.com/challenge/J3WGSreYhc65cWyrc
    public static class AbsoluteSum
    {
        public static int GetAbsSum(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += Math.Abs(nums[i]);
            }

            return result;
        }
    }
}
