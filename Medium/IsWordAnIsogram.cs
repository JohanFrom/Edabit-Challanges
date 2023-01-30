using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Is the Word an Isogram?: https://edabit.com/challenge/aQWAAz6SiApZBA8A8
    public static class IsWordAnIsogram
    {
        public static bool IsIsogram(string str) => str.ToLower().Distinct().Count() == str.Length;
        
    }
}
