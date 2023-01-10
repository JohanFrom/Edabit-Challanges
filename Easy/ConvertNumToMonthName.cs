using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EdabitChallenges.Easy
{
    // Convert Number to Corresponding Month Name: https://edabit.com/challenge/uevxL5FNM77otyo9Z
    public static class ConvertNumToMonthName
    {
        public static string MonthName(int num) => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(num);

    }
}
