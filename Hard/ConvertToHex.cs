using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Convert to Hex: https://edabit.com/challenge/R4YcSt798Krokao2R
    public static class ConvertToHex
    {
        public static string ConvertToHEX(string str)
        {
            string hexString = Convert.ToHexString(Encoding.UTF8.GetBytes(str));
            int index = 0;
            StringBuilder sb = new();

            foreach (char c in hexString)
            {
                sb.AppendFormat("{0}{1}", c, (index++ & 1) == 0 ? "" : " ");
            }


            return sb.ToString().ToLower().TrimEnd();
        }
    }
}
