using EdabitChallenges.Easy;
using EdabitChallenges.VeryEasy;

namespace EdabitChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All challenges are ordered in difficulty level.");
            Console.WriteLine("To test the methods, just use the static class name.methodname");
            Console.WriteLine(AbsoluteSum.GetAbsSum(new int[] { 2, -1, 4, 8, 10 }));
        }
    }
}