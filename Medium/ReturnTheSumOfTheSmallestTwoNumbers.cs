using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Return the Sum of the Two Smallest Numbers: https://edabit.com/challenge/7F8ZhHpxeW7K65XRL
    public static class ReturnTheSumOfTheSmallestTwoNumbers
    {
        public static int SumSmallest(int[] numbers)
        {
            var ordered = numbers.OrderBy(num => num);
            int counter = 0;
            int count = 1;
            foreach (var num in ordered)
            {
                if(num >= 0)
                {
                    counter += num;
                    
                    if (count == 2)
                    {
                        break;
                    }
                    count++;
                }
            }

            return counter;
        }
    }
}
