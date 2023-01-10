using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Filter out Strings from an Array: https://edabit.com/challenge/4eSei6t8emzpyMwvu
    public static class FilterOutStringsFromArray
    {
        public static int[] FilterArray(object[] arr)
        {
            if (arr.Any(a => a.GetType() != typeof(int) && a.GetType() != typeof(string)))
            {
                throw new Exception("Can only contain type string and int");
            }

            int[] newArr = arr.Where(x => x.GetType() == typeof(int)).Cast<int>().ToArray();

            if (arr.GroupBy(x => x).Any(g => g.Count() > 1))
            {
                throw new Exception("Can not contain duplicate numbers");
            }

            return newArr;
        }
    }
}
