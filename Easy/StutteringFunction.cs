using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Stuttering Function: https://edabit.com/challenge/Ty9u8onXNjDPdQGMo
    public static class StutteringFunction
    {
        public static string Stutter(string str) => $"{str[..2]}... {str[..2]}... {str}?";
        
    }
}
