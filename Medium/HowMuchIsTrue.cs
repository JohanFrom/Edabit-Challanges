using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // How Much is True?: https://edabit.com/challenge/afStrS4BkCKums62B
    public static class HowMuchIsTrue
    {
        public static int CountTrue(bool[] arr)
        {
            int counter = 0;
            if (arr.Length == 0) return 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true) counter++;
                if (arr[i] == false) continue;
            }
            
            return counter;
        }
    }
}
