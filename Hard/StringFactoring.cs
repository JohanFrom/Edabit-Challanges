using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // String Factoring: https://edabit.com/challenge/wh9ZuSXZqnjTL69je
    public static class StringFactoring
    {
        public static string StringFactor(int[] arr)
        {
            var groupNumbers = arr.GroupBy(x => x);
            StringBuilder sb = new();

            foreach (var nums in groupNumbers)
                sb.Append(nums.Count() == 1 ? nums.Key + " x " : nums.Key + "^" + nums.Count() + " x ");

            sb.Length -= 3;
            return sb.ToString();   
        }
    }
}
