using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Date Format: https://edabit.com/challenge/mcdSLSmXjYMzEmug2
    public static class DateFormat
    {
        // Did it with a twist
        public static string FormatDate(string date)
        {
            string d = date.Replace("/", string.Empty);
            return $"{d[4..8]}{d[2..4]}{d[0..2]}";
        }
    }
}
