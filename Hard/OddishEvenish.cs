using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Oddish vs. Evenish: https://edabit.com/challenge/r6TSNwkLZ2DgsoKiH
    public static class OddishEvenish
    {
        public static string OddishOrEvenish(int num)
        {
            int total = 0;
            num.ToString().ToCharArray().Select(x => x).ToList().ForEach(x => total += x);

            string returner = (total % 2 == 0) switch
            {
                true => "Evenish",
                false => "Oddish"
            };

            return returner;
        }
    }
}
