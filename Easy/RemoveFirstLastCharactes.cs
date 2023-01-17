using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Remove the First and Last Characters: https://edabit.com/challenge/hjFH2T4Gay7m9ka2m
    public static class RemoveFirstLastCharactes
    {
        public static string RemoveFirstLast(string str) => str.Length <= 2 ? str : str[1..^1];
    }
}
