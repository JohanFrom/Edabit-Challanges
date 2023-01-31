using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Sort Numbers in Descending Order: https://edabit.com/challenge/N5G33s49LDXdhLdsT
    public static class SortNumbersInDescendingOrder
    {
        public static int SortDescending(int num) => int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
    }
}
