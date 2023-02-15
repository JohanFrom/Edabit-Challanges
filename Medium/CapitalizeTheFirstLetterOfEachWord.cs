using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    //Capitalize the First Letter of Each Word: https://edabit.com/challenge/uz4r69EHHSQMosT8D
    public static class CapitalizeTheFirstLetterOfEachWord
    {
        public static string MakeTitle(string str) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);

    }
}
