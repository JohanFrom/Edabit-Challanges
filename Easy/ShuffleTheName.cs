using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Shuffle the Name: https://edabit.com/challenge/c4W4BNymgCC5WkfHp
    public static class ShuffleTheName
    {
        public static string NameShuffle(string name)
        {
            if(!name.Contains(' '))
            {
                throw new ArgumentException("Must have space between firstname and lastname");
            }

            return string.Join(" ", name.Split(' ').Reverse());

        }
        
    }
}
