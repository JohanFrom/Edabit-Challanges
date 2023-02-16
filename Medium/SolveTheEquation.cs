using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Medium
{
    // Solve the Equation: https://edabit.com/challenge/jJshPejQ5C44TPpSv
    public static class SolveTheEquation
    {
        public static int Equation(string equation) => int.Parse(new DataTable().Compute(equation, null).ToString() ?? "0");
    }
}
