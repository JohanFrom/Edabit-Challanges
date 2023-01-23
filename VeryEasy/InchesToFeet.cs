using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Inches to Feet: https://edabit.com/challenge/6FubtR25aQikQv4b6
    public static class InchesToFeet
    {
        public static int InchToFeet(int inches) => inches < 12 ? 0 : inches / 12; 

    }
}
