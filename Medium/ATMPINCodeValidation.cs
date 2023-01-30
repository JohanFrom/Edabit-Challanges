using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // ATM PIN Code Validation: https://edabit.com/challenge/gBYEFXeD9G2JMZ9dD
    public static class ATMPINCodeValidation
    {
        public static bool ValidatePIN(string pin)
        {
            if(pin.Length == 4 || pin.Length == 6 && pin != string.Empty)
            {
                for (int i = 0; i < pin.Length; i++)
                {
                    if (char.IsLetter(pin[i])) return false;
                }
                return true;
            }

            return false;
        }
    }
}
