using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Strange Pair: https://edabit.com/challenge/8Sc582yHht2auBpCY
    public static class StrangePair
    {
        public static bool IsStrangePair(string str1, string str2)
        {
            if((str1 == string.Empty) == (str2 == string.Empty))
            {
                return true;
            }
            if (str1[^1] == str2[0])
            {
                return true;
            }

            return false;
        }
    }
}
