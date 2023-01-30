using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Remove All Special Characters from a String: https://edabit.com/challenge/SfZx7qzXheYQxtQbF
    public static class RemoveAllSpecialCharactersFromString
    {
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new();
            foreach (char c in str) 
            {
                if(!_specialCharacters.Contains(c))
                    sb.Append(c);
            }

            return sb.ToString();   
        }

        private static readonly HashSet<char> _specialCharacters = new()
        {
            '.',
            '!',
            '@',
            '$',
            '%',
            '^',
            '&',
            '\\',
            '*',
            '(',
            ')'
        };
    }
}
