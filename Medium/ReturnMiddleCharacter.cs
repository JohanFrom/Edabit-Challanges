using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Return the Middle Character(s) of a String: https://edabit.com/challenge/JF25KTZEcPzXhBvpM
    public static class ReturnMiddleCharacter
    {
        public static string GetMiddle(string str)
        {
            int offset = str.Length % 2 == 0 ? 1 : 0;
            return str.Substring(str.Length / 2 - offset, offset + 1);
        }
    }
}
