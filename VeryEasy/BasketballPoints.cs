using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Basketball Points: https://edabit.com/challenge/mKLy6ZN4ZhHdWTeQm
    public static class BasketballPoints
    {
        public static int Points(int twoPointers, int threePointers) => (twoPointers * 2) + (threePointers * 3);
    }
}
