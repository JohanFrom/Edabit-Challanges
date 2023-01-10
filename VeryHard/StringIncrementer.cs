using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryHard
{
    // String Incrementer: https://edabit.com/challenge/c9FACYQmN7pBjrgac

    public static class StringIncrementer
    {
        public static string IncrementString(string str)
        {
            string strNumbers = string.Empty;
            string strWord = string.Empty;
            int counter = 0;

            if (str.Any(c => str.Any(c => char.IsDigit(c))) == false)
            {
                return $"{str}1";
            }

            if (str.Any(c => str.Any(c => char.IsDigit(c))) == true)
            {
                char[] chars = str.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i].ToString().Any(c => chars[i].ToString().Any(c => char.IsDigit(c))) == true)
                    {
                        counter++;
                        strNumbers += chars[i].ToString();

                    }
                    else
                    {
                        strWord += chars[i];
                    }
                }

                int appender = int.Parse(strNumbers) + 1;
                strNumbers = appender.ToString().PadLeft(counter, '0');

                if (char.IsDigit(chars[0]) == true)
                {
                    return $"{strNumbers}{strWord}";
                }
                else
                {
                    return $"{strWord}{strNumbers}";
                }
            }

            return str;
        }
    }
}
