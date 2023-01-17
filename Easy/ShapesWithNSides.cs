using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // Shapes With N Sides: https://edabit.com/challenge/YciBg83ihMfGGsA7F
    public static class ShapesWithNSides
    {
        public static string NSidedShape(int num)
        {
            return _sides[num];
        }

        private static readonly Dictionary<int, string> _sides = new()
        {
            {1, "circle"},
            {2, "semi-circle"},
            {3, "triangle"},
            {4, "square"},
            {5, "pentagon"},
            {6, "hexagon"},
            {7, "heptagon"},
            {8, "octagon"},
            {9, "nonagon"},
            {10, "decagon"}
        };
    }
}
