using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Meme Sum Challenge: https://edabit.com/challenge/6APNLL9DAKzsHJfCn
    public static class MemeSum
    {
        public static int MemeSumCalc(int num1, int num2)
        {
            int[] numberOne = GetIntArray(num1);
            int[] numberTwo = GetIntArray(num2);
            int difference;
            string strOut = string.Empty;

            if (numberOne.Length == numberTwo.Length)
            {
                for (int i = 0; i < numberOne.Length; i++)
                {
                    strOut += $"{numberOne[i] + numberTwo[i]}";
                }
            }

            if (numberOne.Length > numberTwo.Length)
            {
                difference = numberOne.Length - 1 + (numberOne.Length - numberTwo.Length);
                string number2 = num2.ToString($"D{difference}");
                //char[] charNumber2 = number2.ToCharArray();

                for (int i = 0; i < numberOne.Length; i++)
                {
                    string numberString = number2[i].ToString();
                    int finishedInt = int.Parse(numberString);
                    strOut += $"{numberOne[i] + finishedInt}";
                }
            }

            if (GetIntArray(num2).Length > GetIntArray(num1).Length)
            {
                difference = numberTwo.Length - 1 + (numberTwo.Length - numberOne.Length);
                string number1 = num1.ToString($"D{difference}");
                //char[] charNumber1 = number1.ToCharArray();

                for (int i = 0; i < numberTwo.Length; i++)
                {
                    string numberString = number1[i].ToString();
                    int finishedInt = int.Parse(numberString);
                    strOut += $"{numberTwo[i] + finishedInt}";
                }
            }

            return int.Parse(strOut);
        }

        internal static int[] GetIntArray(int num)
        {
            List<int> listOfInts = new();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num /= 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}