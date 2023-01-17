using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Modifying the Last Character: https://edabit.com/challenge/ZCAugLuYPbzcC4Eos
    public static class ModifyingLastCharacter
    {
        public static string ModifyLast(string str, int num)
        {
            StringBuilder sb = new();
            sb.Append(str);
            sb.Append(str[^1], num-1);
            return sb.ToString();
        }
    }
}
