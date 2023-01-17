using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Convert Age to Days: https://edabit.com/challenge/nkkKguC5TgWnBiMLA
    public static class ConvertAgeToDays
    {
        public static int CalcAge(int age) => age == 0 ? 0 : age * 365;
        
    }
}
