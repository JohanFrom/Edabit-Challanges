using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Password Validation: https://edabit.com/challenge/etT7orqDDXJF2zGYM
    public static class PasswordValidation
    {
        // Without Regex
        public static bool ValidatePassword(string password)
        {
            // Length check
            if (!(password.Length >= 6 && password.Length <= 24)) 
                return false;

            // Special character check
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsSymbol(password[i]))
                {
                    if (!_specialCharacters.Contains(password[i]))
                        return false;
                }
            }
            // Contains at least one digit, uppercase and lowercase
            if (!password.Any(char.IsDigit) || !password.Any(char.IsUpper) || !password.Any(char.IsLower)) 
                return false;
            

            // No repeating characters (case sensitive)
            if(password.Where((c, i) => i >= 2 && password[i - 1] == c && password[i - 2] == c).Any())
                return false;
            
            return true;
        }

        private static readonly HashSet<char> _specialCharacters = new()
        {
            '!',
            '@',
            '#',
            '$',
            '%',
            '^',
            '&',
            '*',
            '(',
            ')',
            '+',
            '=',
            '_',
            '-',
            '{',
            '}',
            '[',
            ']',
            ':',
            ';',
            '"',
            '\'',
            '?',
            '<',
            '>',
            ',',
            '.'
        };
    }
}
