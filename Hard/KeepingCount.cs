using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Keeping Count: https://edabit.com/challenge/apYBsyuhCDH33hQSW
    public static class KeepingCount
    {
        public static int DigitCount(int num)
        {
            string number = num.ToString();
            StringBuilder sb = new();
            for (int i = 0; i < number.Length; i++)
            {
                sb.Append(number.Count(n => n == number[i]));
            }
            return int.Parse(sb.ToString());
        }
    }
}
