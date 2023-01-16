using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Excel Sheet Column Number: https://edabit.com/challenge/Dq2etCDAtTrPe2Xq6
    public static class ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string str)
        {
            int value = 0;
            foreach(var c in str)
            {
                value *= 26;
                value += c - 'A' + 1;
            }
            return value;
        }
    }
}
