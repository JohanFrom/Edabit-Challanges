using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // FizzBuzz Interview Question: https://edabit.com/challenge/FrEEkHfph2pjfE4Ry
    public static class FizzBuzzInterviewQuestion
    {
        public static string FizzBuzz(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
                return "FizzBuzz";
            else if (num % 3 == 0)
                return "Fizz";
            else if (num % 5 == 0)
                return "Buzz";
            return num.ToString();
        }
    }
}
