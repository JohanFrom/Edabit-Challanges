using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Reversing a Binary String: https://edabit.com/challenge/TgtrCxdZxjaNBKvk3
    public static class ReversingBinaryString
    {
        public static int ReversedBinaryInteger(int num) => Convert.ToInt32(new string(Convert.ToString(num, 2).Reverse().ToArray()), 2);
        
    }
}
