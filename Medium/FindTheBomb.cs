using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Find the Bomb: https://edabit.com/challenge/JYEufqRvkusjr5R58
    public static class FindTheBomb
    {
        public static string Bomb(string str) => str.ToLower().Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
    }
}
