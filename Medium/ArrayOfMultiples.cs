using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Array of Multiples: https://edabit.com/challenge/2QvnWexKoLfcJkSsc
    public static class ArrayOfMultiples
    {
        public static int[] ArrayMultiplies(int num, int length)
        {
            StringBuilder sb = new();
            for (int i = 1; i <= length; i++)
            {
                sb.Append(num * i + " ");
            }

            sb.Length -= 1;
            return sb.ToString().Split(" ").Select(x => int.Parse(x)).ToArray();
        }
    }
}
