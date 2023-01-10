using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Count the Number of Duplicate Characters: https://edabit.com/challenge/wXCzoLtvvEEYBs3p9
    public static class CountNumbersOfDuplicateCharacters
    {
        public static int DuplicateCount(string str) => str.GroupBy(x => x).Select(y => y).Where(z => z.Count() > 1).Count();
    }
}
