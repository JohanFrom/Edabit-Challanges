using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // 12 vs 24 Hours: https://edabit.com/challenge/YPxdWZaBbB5mbqW7i
    public static class _12vs24Hours
    {
        public static string ConvertTime(string time)
        {
            string suffix = time[^2..];
            string[] timeArr = _suffixes.Contains(suffix) ? time.Replace(suffix, string.Empty).Trim().Split(':') : time.Split(':');
            int hour = 12;
            int minute = 0; 
            StringBuilder sb = new();

            if (suffix == "pm")
            {
                hour += int.Parse(timeArr[0]);
                minute += int.Parse(timeArr[1]);
                sb.Append(hour + ":" + (minute == 0 ? "00" : minute));
            }
            else if(suffix == "am")
            {
                hour -= int.Parse(timeArr[0]);
                minute -= int.Parse(timeArr[1]);
                sb.Append(hour + ":" + ( minute == 0 ? "00" : minute));
            }
            else
            {
                if (int.Parse(timeArr[0]) <= 12) 
                {
                    sb.Append(timeArr[0] + ":" + timeArr[1] + " am");
                }
                else
                {
                    hour = int.Parse(timeArr[0]) - 12;
                    sb.Append(hour + ":" + timeArr[1] + " pm");
                }
            }

            return sb.ToString();
        }

        private static readonly HashSet<string> _suffixes = new()
        {
            "am",
            "pm"
        };
    }
}
