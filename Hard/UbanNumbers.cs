using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Uban Numbers: https://edabit.com/challenge/v2wstc4QEfiyXK6D5
    public static class UbanNumbers
    {
        public static bool IsUban(int num)
        {
            if (num > 999 && num <= 999999)
                return false;
            else if (num > 999999)
                return true;
            else if (num > 99)
                return false;
            else
                return num % 10 != 4;
        }
    }
}
