using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // Maximum Occurrence: https://edabit.com/challenge/vtdfueRCmpRGyLAGs
    public static class MaximumOccurence
    {
        public static string MaxOccur(string str)
        {
            Dictionary<char, int> dict = new();
            StringBuilder sb = new();

            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            int maximum = dict.Values.Max();
            var resultArr = dict.Where(x => x.Value == maximum).Select(b => b.Key).ToArray();

            foreach (var item in resultArr)
            {
                if (resultArr.Length == str.Length)
                {
                    sb.Append("No Repetition" + ", ");
                    break;
                }
                    
                else if(resultArr.Length == 1)
                {
                    sb.Append(item);
                }
                else if(item == ' ')
                {
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(item);
                }

                sb.Append(", ");
            }

            sb.Length -= 2;          
            return sb.ToString();
        }
    }
}
