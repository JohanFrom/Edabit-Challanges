using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Football Points: https://edabit.com/challenge/R8hKBE5wcNivmtPQ7
    public static class FootballPoints
    {
        public static int Points(int wins, int draws, int losses) => (wins * 3) + (draws * 1) + (losses * 0);
    }
}
