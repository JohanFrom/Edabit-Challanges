using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // H4ck3r Sp34k: https://edabit.com/challenge/7nzfry4P3WrrL7t38
    public static class H4ck3rSp34k
    {
        public static string HackerSpeak(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a')
                    chars[i] = '4';
                else if (chars[i] == 'e')
                    chars[i] = '3';
                else if (chars[i] == 'i')
                    chars[i] = '1';
                else if (chars[i] == 'o')
                    chars[i] = '0';
                else if (chars[i] == 's')
                    chars[i] = '5';
            }

            return new string(chars);
        }
    }
}
