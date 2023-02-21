using EdabitChallenges.VeryEasy;
using EdabitChallenges.Easy;
using EdabitChallenges.Medium;
using EdabitChallenges.Hard;
using EdabitChallenges.VeryHard;
using EdabitChallenges.Expert;
using System.Text;

namespace EdabitChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All challenges are ordered in difficulty level.");
            Console.WriteLine("To test the methods, just use the static class name.methodname e.g. TheCollatzConjecture.Collatz()");

            CountCompletedChallenges();
            SearchChallengeSolution("Return the");
        }

        #region Counter and Search methods for challenges

        private static readonly Dictionary<string, int> _solutions = new()
        {
            {"VeryEasy", 0},
            {"Easy", 0},
            {"Medium", 0},
            {"Hard", 0},
            {"VeryHard", 0},
            {"Expert", 0}
        };

        private static readonly HashSet<string> _exludedDirs = new()
        {
            ".git",
            ".github",
            ".vs",
            "bin",
            "obj"
        };

        /// <summary>
        /// Method for counting the completed challenges in this solution
        /// </summary>
        public static void CountCompletedChallenges()
        {
            Console.WriteLine("");
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
            Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);
        }

        /// <summary>
        /// Method for finding a specific or multiple challenges based on a challenge name or a url
        /// </summary>
        /// <param name="challengeName"></param>
        /// <param name="challengeUrl"></param>
        /// <returns>String of file path/s</returns>
        public static void SearchChallengeSolution(string? challengeName = null, string? challengeUrl = null)
        {
            if (challengeName == null && challengeUrl == null)
            {
                Console.WriteLine("Must enter either a challenge name or a challenge url!");
                return;
            }

            if (challengeName == string.Empty && challengeUrl == string.Empty)
            {
                Console.WriteLine("Must enter either a challenge name or a challenge url!");
                return;
            }

            StringBuilder sb = new();

            string netFolder = new DirectoryInfo(Directory.GetCurrentDirectory()).ToString();
            DirectoryInfo startDirectory = Directory.GetParent(netFolder)!.Parent!.Parent!;
            var dirs = startDirectory.GetDirectories().Where(x => !_exludedDirs.Contains(x.ToString().Split("\\").Last()));

            foreach (var dir in dirs)
            {
                string[] files = Directory.GetFiles(dir.ToString(), "*.cs");
                foreach (var file in files)
                {
                    var fileContent = File.ReadLines(file.ToString()).Take(12);

                    foreach (var line in fileContent)
                    {
                        string[] splittedPath = file.Split('\\');
                        string fixedStr = string.Join('\\', splittedPath[(splittedPath.Length - 2)..]);
                        if (challengeName != null && challengeName != string.Empty)
                        {
                            if (line.ToLower().Contains(challengeName.ToLower()))
                            {
                                if (!sb.ToString().Contains(fixedStr))
                                    sb.AppendLine(fixedStr);
                            }
                        }
                        if (challengeUrl != null && challengeUrl != string.Empty)
                        {
                            if (line.ToLower().Contains(challengeUrl.ToLower()))
                            {
                                sb.AppendLine(fixedStr);
                                break;
                            }
                        }
                    }
                }
            }
            
            if(sb.ToString() == string.Empty)
            {
                Console.WriteLine("");
                Console.WriteLine("Could not find a path to a challenge!");
                return;
            }
            
            var splittedResult = sb.ToString().Split("\r\n").ToList();
            List<string> orderedDifficulty = new(){ "VeryEasy", "Easy", "Medium", "Hard", "VeryHard", "Expert" };

            foreach (var challenge in splittedResult.OrderBy(x => orderedDifficulty.IndexOf(x.Split("\\")[0])))
            {
                Console.WriteLine(challenge);
            }
        }

        #endregion
    }
}