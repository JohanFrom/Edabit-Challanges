using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Moran Numbers: https://edabit.com/challenge/jTvrj9WZzKFhA5BcD
    public static class MoranNumbers
    {
        public static string Moran(int num)
        {
            double sumOfInt = CalculateSumOfInt(num);
            return CalculateSumOfInt(num) == 0 ? IsPrime(num / sumOfInt) ? "M" : "H" : "Neither";
        }

        internal static double CalculateSumOfInt(int num) => num.ToString().Select(digit => int.Parse(digit.ToString())).Sum();

        internal static bool IsPrime(double num)
        {
            int a = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            return a == 2;
        }
    }
}
