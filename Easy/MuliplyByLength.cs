using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Multiply by Length: https://edabit.com/challenge/WLH46r3aARtXXYKF6
    public static class MuliplyByLength
    {
        public static int[] MultiplyByLength(int[] arr)=>  arr.Select(x => x * arr.Length).ToArray();
        
    }
}
