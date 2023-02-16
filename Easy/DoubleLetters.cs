using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Double Letters: https://edabit.com/challenge/ugg9ZK7xY5vk5qJXr
    public static class DoubleLetters
    {
        public static bool DoubleLettersCheck(string str)
        {
            HashSet<char> h = new();
            for (int i = 0; i <= str.Length - 1; i++)
            {
                if (h.Contains(str[i]))
                    return true;
                else
                    h.Add(str[i]);
            }

            return false;
        }
    }
}
