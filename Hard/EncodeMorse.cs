using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Encode Morse: https://edabit.com/challenge/SYqKptGmoRmhAwLZc
    public static class EncodeMorse
    {
        public static string Encode(string str)
        {
            char[] chars = str.ToUpper().ToCharArray();
            StringBuilder sb = new();
            for (int i = 0; i < chars.Length; i++)
            {
                if (_morseDict.ContainsKey(chars[i]))
                {
                    sb.Append(_morseDict[chars[i]]);
                    sb.Append(' ');
                }
                else if (chars[i] == ' ')
                {
                    sb.Append("  ");
                }
                else
                {
                    Console.WriteLine("Value does not exists");
                }
            }

            return sb.ToString().TrimStart().TrimEnd();
        }

        private static readonly Dictionary<char, string> _morseDict = new()
        {
            {'A', ".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-"},
            {'L', ".-.."},
            {'M', "--"},
            {'N', "-."},
            {'O', "---"},
            {'P', ".--."},
            {'Q', "--.-"},
            {'R', ".-."},
            {'S', "..."},
            {'T', "-"},
            {'U', "..-"},
            {'V', "...-"},
            {'W', ".--"},
            {'X', "-..-"},
            {'Y', "-.--"},
            {'Z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {'.', ".-.-.-"},
            {',', "--..--"},
            {'?', "..--.."},
            {'!', "-.-.--"},
            {'\'', ".----." },
            {':', "---"}
        };
    }
}
