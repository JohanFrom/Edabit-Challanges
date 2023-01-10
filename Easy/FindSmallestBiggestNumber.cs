using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    public static class FindSmallestBiggestNumber
    {
        public static int[] FindMinMax(int[] nums)
        {
            if(nums.Length == 1)
                return new int[2] { nums[0], nums[0] };
            

            return new int[2] {nums.Min(), nums.Max()};
        }
    }
}
