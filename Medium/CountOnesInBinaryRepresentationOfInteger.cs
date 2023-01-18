using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Count Ones in Binary Representation of Integer: https://edabit.com/challenge/zn3A3AAzoE7vezw7Q
    public static class CountOnesInBinaryRepresentationOfInteger
    {
        public static int CountOnes(int num) => Convert.ToString(num, 2).Split('1').Length - 1;
    }
}
