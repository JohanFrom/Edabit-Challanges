using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Break Point: https://edabit.com/challenge/pNCrbWDTYrsuQ37TP
    public static class BreakPoint
    {
        // Working?
        public static bool PointBreak(int num)
        {
            var numChars = num.ToString().ToCharArray();
            bool isDivisable = num.ToString().Length % 2 == 0;
            int divider = isDivisable == true ? num.ToString().Length / 2 : (num.ToString().Length / 2) + 1;

            bool result = (SumOfCharArray(numChars[0..divider]) == SumOfCharArray(numChars[divider..])) switch
            {
                true => true,
                false => false,
            };

            if(result == false){
                int d = num.ToString().Length - 1;
                if(SumOfCharArray(numChars[0..d]) == SumOfCharArray(numChars[d..])){
                    return true;
                }
            }

            return result;           
        }

        internal static int SumOfCharArray(char[] chars) => chars.Select(digit => int.Parse(digit.ToString())).Sum();
         
    }
}
