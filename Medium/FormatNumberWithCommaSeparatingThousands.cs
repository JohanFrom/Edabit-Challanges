using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Format Number with Comma(s) Separating Thousands: https://edabit.com/challenge/GvGSPC9wiY4bS9AMg
    public static class FormatNumberWithCommaSeparatingThousands
    {
        public static string FormatNum(int num) => num.ToString("N0", new CultureInfo("en-US"));
    }
}
