using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Maximum Edge of a Triangle: https://edabit.com/challenge/BFv477kwQm7HDHb6p
    public static class MaximumEdgeOfATriangle
    {
        public static int NextEdge(int side1, int side2) => (side1+ side2) - 1;
    }
}
