using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // The Museum of Incredibly DULL Things: https://edabit.com/challenge/dgHXtSrgyWbJ3cXvL
    public static class TheMuseumOfIncrediblyDULLThings
    {
        public static int[] RemoveSmallest(int[] arr)
        {
            if(arr.Length == 0) return Array.Empty<int>();
            var list = arr.ToList();
            list.RemoveAt(list.IndexOf(arr.Min()));
            return list.ToArray();
        }
    }
}
