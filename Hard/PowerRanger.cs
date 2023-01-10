using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Power Ranger: https://edabit.com/challenge/McGCFZYn8ikn3GSqz
    public static class PowerRanger
    {
        public static int PowerRangerCalc(int power, int min, int max)
        {
            int count = 0;
            for (int i = 1; i <= max; i++)
            {
                if (Math.Pow(i, power) >= min && Math.Pow(i, power) <= max)
                {
                    count++; 
                }
            }
            return count;
        }
    }
}
