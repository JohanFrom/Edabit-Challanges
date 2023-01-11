using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Return the Factorial: https://edabit.com/challenge/PmhP5mXMRrBoH3WoB
    public static class ReturnTheFactorial
    {
        public static int Factorial(int num)
        {
            int fact = 1;
            do
            {
                fact *= num;
                num--;
            } while (num > 0);
            return fact;
        }
    }
}
