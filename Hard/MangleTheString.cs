using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Mangle the String: https://edabit.com/challenge/uMKovaP8LRrNTsJJx
    public static class MangleTheString
    {
        public static string Mangle(string str)
        {
            StringBuilder sb = new();
            foreach (var c in str.ToCharArray())
            {
                if(c == ' ')
                    sb.Append(' '); 
                
                else if (!char.IsLetter(c))
                    sb.Append(c);
                else
                {
                    int charNum = (int)c + 1;
                    char letter = (char)charNum;
                    if (_vowels.Contains(letter.ToString()))
                        sb.Append(letter.ToString().ToUpper());
                    else
                        sb.Append(letter.ToString());  
                }  
            }
            
            return sb.ToString();
        }

        private static readonly HashSet<string> _vowels = new(StringComparer.InvariantCultureIgnoreCase)
        {
            "a",
            "e",
            "i",
            "o",
            "u"
        };

    }
}
