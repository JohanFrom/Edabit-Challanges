using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Expert
{
    // Prefix Notation Evaluation: https://edabit.com/challenge/vQTiy9fvwRuLWs37W
    public static class PrefixNotationEvaluation
    {
        // Have not tested all the cases!
        public static int Prefix(string exp)
        {
            string[] splittedExp = exp.TrimStart().TrimEnd().Split(" ");
            string operation = splittedExp[0].Trim();
            int[] values = Array.ConvertAll(splittedExp[1..], s => int.Parse(s));

            return operation switch
            {
                "+" => PlusOperation(values),
                "-" => SubtractOperation(values),
                "/" => DivideOperation(values),
                "*" => MultiplyOperation(values),
                _ => 1
            };
        }

        private static int PlusOperation(int[] values)
        {
            int result = 0;
            for (int i = 0; i < values.Length; i++)
            {
                result += values[i];
            }
            return result;
        }

        private static int SubtractOperation(int[] values)
        {
            int result = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if(values[i] < 0)
                    result += values[i];
                else
                    result -= values[i];
            }
            return result;
        }

        private static int DivideOperation(int[] values)
        {
            int result = values[0]; 
            for (int i = 1; i < values.Length; i++)
            {
                result /= values[i];
            }
            return result;
        }

        private static int MultiplyOperation(int[] values)
        {
            int result = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                result *= values[i];
            }
            return result;
        }
    }
}
