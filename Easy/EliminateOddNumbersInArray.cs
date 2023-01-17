using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Eliminate Odd Numbers within an Array: https://edabit.com/challenge/HkKNhhdfEGwxm9Fq6
    public static class EliminateOddNumbersInArray
    {
        public static int[] NoOdds(int[] numbers) => numbers.Where(x => x % 2 == 0).ToArray();
    }
}
