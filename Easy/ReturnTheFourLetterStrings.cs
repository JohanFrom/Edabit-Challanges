using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Return the Four Letter Strings: https://edabit.com/challenge/W4x4o2M7ny6Cqkfhn
    public static class ReturnTheFourLetterStrings
    {
        public static string[] IsFourLetters(string[] strArr) => strArr.Where(x => x.Length == 4).ToArray();
    }
}
