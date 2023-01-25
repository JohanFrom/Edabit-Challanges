using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Find the Characters Counterpart Char Code: https://edabit.com/challenge/zaokQWNdEudmFWpk7
    public class FindTheCharactersCounterpartCharCode
    {
        public static int CounterPartCharCode(char c) => char.IsUpper(c) ? (int)char.ToLower(c) : (int)char.ToUpper(c);
    }
}
