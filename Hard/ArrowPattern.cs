using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Arrow Pattern: https://edabit.com/challenge/o78QKtvqsP4XTS5TJ
    public static class ArrowPattern
    {
        public static string[] Arrow(int num)
        {
            List<string> list = new(); 

            if(num % 2 != 0)
            {
                for (int i = 0; i < num + 1; i++)
                {
                    list.Add(new string('>', i));
                }

                for (int i = num; i-- > 0;)
                {
                    list.Add(new string('>', i));

                }
            }
            else
            {
                for (int i = 1; i < num + 1; i++)
                {
                    list.Add(new string('>', i));

                }

                for (int i = num + 1; i -- > 0;)
                {
                    list.Add(new string('>', i));

                }
            }

            return list.Where(x => x != string.Empty).ToArray();
        }
    }
}
