using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Finding Nemo: https://edabit.com/challenge/ynZfn2LifKN25fP84
    public static class FindingNemo
    {
        public static string FindNemo(string str)
        {
            int index = 0;
            foreach (string s in str.Split(" "))
            {
                if (s.Contains("Nemo"))
                {
                    index = 1 + 1;
                    break;
                }
            }

            return index == 0 ? "I can't find Nemo :(" : $"I found Nemo at {index}!" ;
        }
    }
}
