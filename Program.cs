using EdabitChallenges.VeryEasy;
using EdabitChallenges.Easy;
using EdabitChallenges.Medium;
using EdabitChallenges.Hard;
using EdabitChallenges.VeryHard;
using EdabitChallenges.Expert;

namespace EdabitChallenges
{
    internal class Program
    {
        private static readonly Dictionary<string, int> _solutions = new()
        {
            {"VeryEasy", 0},
            {"Easy", 0},
            {"Medium", 0},
            {"Hard", 0},
            {"VeryHard", 0},
            {"Expert", 0}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("All challenges are ordered in difficulty level.");
            Console.WriteLine("To test the methods, just use the static class name.methodname e.g. TheCollatzConjecture.Collatz()");

            CountCompletedChallenges();
        }

        public static void CountCompletedChallenges()
        {
            string netFolder = new DirectoryInfo(Directory.GetCurrentDirectory()).ToString();
            string startDirectory = Directory.GetParent(netFolder)!.Parent!.Parent!.FullName;
            FileInfo[] fileInfo;
            DirectoryInfo directoryInfo;

            foreach (KeyValuePair<string, int> folder in _solutions)
            {
                directoryInfo = new(startDirectory + "//" + folder.Key);
                fileInfo = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
                _solutions[folder.Key] = fileInfo.Length;
            }

            Console.WriteLine("");
            foreach (KeyValuePair<string, int> folder in _solutions)
            {
                if (folder.Key.Contains("Very"))
                {
                    Console.WriteLine("Difficulty: " + folder.Key.Insert(4, " ") + Environment.NewLine +
                    "Completed: " + folder.Value.ToString() + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("Difficulty: " + folder.Key + Environment.NewLine +
                    "Completed: " + folder.Value.ToString() + Environment.NewLine);
                }
            }
            Console.Write("Total completed challenges: ");
            Console.Write(_solutions.Values.Sum(x => x).ToString(), Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine(Environment.NewLine, Console.ForegroundColor = ConsoleColor.White); 

        }
    }
}