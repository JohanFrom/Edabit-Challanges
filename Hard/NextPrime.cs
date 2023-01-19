using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Next Prime: https://edabit.com/challenge/FKb8JY75nkaHz7B3F
    public static class NextPrime
    {
        public static int PrimeNext(int num)
        {
            if (num > 2 && num % 2 == 0)
                ++num;

            while (!IsPrime(num))
            {
                num += 2;
            }

            return num;
        }

        private static bool IsPrime(int num)
        {
            if (num <= 1 && num % 2 == 0)
                return false;

            if (num == 2)
                return true;

            double root = Math.Pow(num, 0.5);

            for (int i = 3; i < root; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;

        }
    }
}
