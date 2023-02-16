using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Xs and Os, Nobody Knows: https://edabit.com/challenge/irKy94NboMHSMzjEL
    public static class XAndONobodyKnows
    {
        public static bool XO(string str) => str.ToLower().Count(x => x == 'x') == str.ToLower().Count(x => x == 'o');
    }
}
