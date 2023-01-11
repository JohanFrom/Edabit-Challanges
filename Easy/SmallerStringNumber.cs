using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Smaller String Number: https://edabit.com/challenge/uBqpafqjoYNPuQ7Pr
    public static class SmallerStringNumber
    {
        public static string SmallerNumber(string num1, string num2) => string.Compare(num1, num2) > 0 ? num1 : num2;
        
    }
}
