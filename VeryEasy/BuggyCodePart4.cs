using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Buggy Code (Part 4): https://edabit.com/challenge/uEHqNqt7MBEvn9QKa
    public static class BuggyCodePart4
    {
        public static string Greeting(string str) => str == "Mubashir" ? "Hello, my Love!" : $"Hello, {str}!";
    }
}
