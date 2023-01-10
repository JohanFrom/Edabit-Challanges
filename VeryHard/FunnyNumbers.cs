using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Funny Numbers: https://edabit.com/challenge/ixBrn5gukJR6aHJdp
    public static class FunnyNumbers
    {
        public static int? FunnyNumbersCalc(int num, int divider)
        {
            double newNum = 0;
            double power = divider;

            for (int i = 0; i < num.ToString().Length; i++)
            {
                newNum += Math.Pow(double.Parse(num.ToString()[i].ToString()), power);
                power++;
            }

            return num * divider == newNum ? divider : null;
        }
    }
}
