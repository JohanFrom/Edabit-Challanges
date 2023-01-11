using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Simplified Fractions: https://edabit.com/challenge/3wT3QcDdfvMR3amjc
    public static class SimplifiedFractions
    {
        public static string Simplify(string str)
        {
            int[] intArr = new int[] { int.Parse(str.Split('/')[0]), int.Parse(str.Split('/')[1]) };
            int gcd = GCD(intArr);

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] /= gcd;
            }

            if (intArr[0] > intArr[1]) 
                return intArr[0].ToString();
                  
            return new string(intArr[0].ToString() + '/' + intArr[1].ToString());
        }

        internal static int GCD(int a, int b)
        {
            while (b > 0)
            {
                int rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }

        internal static int GCD(int[] args) =>  args.Aggregate((gcd, arg) => GCD(gcd, arg));
    }
}
