using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Sock Pairs: https://edabit.com/challenge/C6wN5vGodWvWL7ZaK
    public static class SockPairs
    {
        public static int PairsOfSocks(string str) =>
            str.ToCharArray()
                .GroupBy(item => item)
                .ToDictionary(item => item.Key, item => item.Count())
                .Select(x => x.Value / 2).Sum();
    }
}
