using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Recursion to Repeat a String n Number of Times: https://edabit.com/challenge/MrTxAwggfKFcQXBda
    public static class RecursionRepeatStringNumberOfTimes
    {
        public static string Repetition(string txt, int n) => (n <= 1) ? txt : txt + Repetition(txt, n - 1); 
        
    }
}
