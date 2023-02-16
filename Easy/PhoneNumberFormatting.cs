using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Phone Number Formatting: https://edabit.com/challenge/b59CKJivMhobiqWDu
    public static class PhoneNumberFormatting
    {
        public static string FormatPhoneNumber(int[] arr) => $"({string.Concat(arr[0..3])}) {string.Concat(arr[3..6])}-{string.Concat(arr[6..10])}";
    }
}
