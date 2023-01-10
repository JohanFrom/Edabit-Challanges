using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Expert
{
    // Building a Binary Clock: https://edabit.com/challenge/DZL7PpHQyPvkYiyDL
    public static class BuildingBinaryClock
    {
        public static string[] BinaryClock(string time)
        {
            string strTime = time.Replace(":", "");
            string strBinary = string.Empty;

            for (int x = 0; x <= strTime.Length - 1; x++)
            {
                int bcAmount = 3;

                if (x == 2 || x == 4) bcAmount = 2;

                else if (x == 0) bcAmount = 1;

                for (int i = 0; i <= bcAmount; i++)
                {
                    string BinaryString = Convert.ToString(strTime[x], 2);

                    if (BinaryString[^(i + 1)] == '1') strBinary += BinaryString[^(i + 1)].ToString();

                    else strBinary += BinaryString[^(i + 1)].ToString();

                }
            }

            char[] charBinary = strBinary.ToCharArray();
            return new string[]
            {
                $" {charBinary[5]} {charBinary[12]} {charBinary[19]}",
                $" {charBinary[4]}{charBinary[8]}{charBinary[11]}{charBinary[15]}{charBinary[18]}",
                $"{charBinary[1]}{charBinary[3]}{charBinary[7]}{charBinary[10]}{charBinary[14]}{charBinary[17]}",
                $"{charBinary[0]}{charBinary[2]}{charBinary[6]}{charBinary[9]}{charBinary[13]}{charBinary[16]}"
            };
        }
    }
}
