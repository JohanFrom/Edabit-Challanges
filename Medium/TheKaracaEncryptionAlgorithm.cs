using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // The Karaca's Encryption Algorithm: https://edabit.com/challenge/TLWqG49uMLa7zgxPE
    public static class TheKaracaEncryptionAlgorithm
    {
        public static string Encrypt(string word)
        {
            string reversed = string.Concat(word.Reverse());
            StringBuilder sb = new();
            for (int i = 0; i < reversed.Length; i++)
            {
                sb.Append(_vowels.ContainsKey(reversed[i]) ? _vowels[reversed[i]] : reversed[i]);
            }

            return sb.Append("aca").ToString();
        }

        private static readonly Dictionary<char, char> _vowels = new()
        {
            {'a', '0'},
            {'e', '1'},
            {'i', '2'},
            {'o', '3'},
            {'u', '4'},
        };
    }
}
