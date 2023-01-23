using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Divides Evenly: https://edabit.com/challenge/ghJ7G5jtKprtjfep2
    public static class DividesEvenly
    {
        public static bool DivideEvenly(int a, int b) => a / b % 2 == 0;
    }
}
