using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Reverse Coding Challenge #2: https://edabit.com/challenge/PGLjsEXWB5AWdoFGY
    public static class ReverseCodingChallengeTwo
    {
        public static int MysteryFunc(int num)
        {
            int counter = 2;
            StringBuilder sb = new();
            for (int i = 0; i < num; i++)
            {
                if (counter <= num)
                {
                    sb.Append(2);
                    counter *= 2;
                }
                else
                {
                    break;
                }
            }

            sb.Append(num - Math.Pow(2, sb.ToString().Length));
            return int.Parse(sb.ToString());
        }
    }
}
