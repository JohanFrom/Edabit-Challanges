using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Convert All Array Items to String: https://edabit.com/challenge/hqTYj7NbLnCcjxryi
    public static class ConvertAllArrayItemsToString
    {
        public static string[] ParseArray(object[] arr)
        {
            if(arr == null || arr.Length == 0) 
                return Array.Empty<string>();

            return arr.Select(x => x.ToString()).ToArray()!;
        }
    }
}
