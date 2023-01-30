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

        static void Main(string[] args)
        {
            Console.WriteLine("All challenges are ordered in difficulty level.");
            Console.WriteLine("To test the methods, just use the static class name.methodname e.g. TheCollatzConjecture.Collatz()");
            Console.WriteLine(TestingKSquaredKEqualsN.KToK("4", 2));
            CountCompletedChallenges();

            //Console.WriteLine(SearchChallengeSolution("Absolute Sum", null));
        }
        
        /// <summary>
        /// Method for counting the completed challenges in this solution
        /// </summary>
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

        /// <summary>
        /// Method for finding a specific or multiple challenges based on a challenge name or a url
        /// </summary>
        /// <param name="challengeName"></param>
        /// <param name="challengeUrl"></param>
        /// <returns>String of file path/s</returns>
        public static string SearchChallengeSolution(string? challengeName, string? challengeUrl)
        {
            if (challengeName == null && challengeUrl == null)
                return "Must enter either a challenge name or a challenge url!";
            
            if (challengeName == string.Empty && challengeUrl == string.Empty)
                return "Must enter either a challenge name or a challenge url!";

            StringBuilder sb = new();
            string netFolder = new DirectoryInfo(Directory.GetCurrentDirectory()).ToString();
            DirectoryInfo startDirectory = Directory.GetParent(netFolder)!.Parent!.Parent!;
            var dirs = startDirectory.GetDirectories().Where(x => !_exludedDirs.Contains(x.ToString().Split("\\").Last()));

            foreach (var dir in dirs) 
            {
                string[] files = Directory.GetFiles(dir.ToString(), "*.cs");
                foreach(var file in files)
                {
                    string[] fileContent = File.ReadAllLines(file.ToString());

                    for (int i = 0; i <= 11; i++)
                    {
                        if(challengeName != null && challengeName != string.Empty)
                        {
                            if (fileContent[i].Contains(challengeName))
                            {
                                if (!sb.ToString().Contains(file))
                                    sb.AppendLine(file);
                            }   
                        }
                        if(challengeUrl != null && challengeUrl != string.Empty)
                        {
                            if (fileContent[i].Contains(challengeUrl))
                            {
                                sb.AppendLine(file);
                                break;
                            }      
                        }  
                    }   
                }
            }

            return sb.ToString() == string.Empty ? "Could not find a path to a challenge!" : sb.ToString();
        }
    }
}