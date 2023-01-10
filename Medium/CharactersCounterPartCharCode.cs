using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Find the Characters Counterpart Char Code: https://edabit.com/challenge/zaokQWNdEudmFWpk7
    public static class CharactersCounterPartCharCode
    {
        public static int CounterpartCharCode(char symbol)
        {
            if (char.IsDigit(symbol))
                return Encoding.UTF8.GetBytes(symbol.ToString())[0];
            else if (char.IsUpper(symbol))
                return Encoding.UTF8.GetBytes(symbol.ToString().ToLower())[0];
            else if (char.IsLower(symbol))
                return Encoding.UTF8.GetBytes(symbol.ToString().ToUpper())[0];      
            else
                return 0;
            
        }
    }
}
