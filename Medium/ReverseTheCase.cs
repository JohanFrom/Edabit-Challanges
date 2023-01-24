using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Reverse the Case: https://edabit.com/challenge/99oN5igrbXddAjHEL
    public static class ReverseTheCase
    {
        public static string ReverseCase(string str) => string.Concat(str.Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x)));
        
    }
}
