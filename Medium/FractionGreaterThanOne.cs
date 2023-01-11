using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Fraction Greater Than One: https://edabit.com/challenge/uCtG3Gtfx7fgNWM58
    public static class FractionGreaterThanOne
    {
        public static bool GreaterThanOne(string str)
        {
            string[] nums = str.Split('/');
            return nums[0] != nums[1] && (string.Compare(nums[0], nums[1]) >= 0);
        }
    }
}
