using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Re-Form the Word: https://edabit.com/challenge/ypLHBBJtdME9pvTuN
    public static class ReFormTheWord
    {
        public static string GetWord(string str1, string str2) =>  $"{str1}{str2}"[0].ToString().ToUpper() + $"{str1}{str2}"[1..];
        
    }
}
