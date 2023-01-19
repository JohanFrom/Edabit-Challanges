using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Working 9 to 5: https://edabit.com/challenge/rkzH6YsPNgoJjn75i
    public static class WorkingNineToFive
    {
        public static string OverTime(double[] arr)
        {
            double normalWorkedHours = Math.Min(arr[1], 17) - Math.Min(arr[0], 17);
            double overTimeWorkedHours = Math.Max(arr[1], 17) - Math.Max(arr[0], 17);
            double moneyCalculation = (normalWorkedHours * arr[2]) + (overTimeWorkedHours * arr[2] * arr[3]);

            return (moneyCalculation % 1 == 0) switch
            {
                true => $"${moneyCalculation.ToString("N2").Replace(",", ".")}",
                false => $"${moneyCalculation.ToString("N2").Replace(",", ".")}"
            };
            
        }
    }
}
