using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Maskify the String: https://edabit.com/challenge/RFeBL2TzSf7mRMNJi
    public static class MaskifyTheString
    {
        public static string Maskify(string str)
        {
            if(str == string.Empty)
                return string.Empty;
            
            if(str.Length < 4)
                return str;
    
            string visiblePart = str[^4..];
            string hiddenPart = string.Concat(str[..^visiblePart.Length].ToCharArray().Select(x => x = '#').ToArray());
            return hiddenPart + visiblePart;
        }
    }
}
