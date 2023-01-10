using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // ReverseAndNot: https://edabit.com/challenge/YGhgctqPsKQxQQCFS
    public static class ReverseAndNot
    {
        public static string ReverseNot(int i) => string.Join("", Enumerable.Reverse(i.ToString()).Concat(i.ToString()));
    }
}
