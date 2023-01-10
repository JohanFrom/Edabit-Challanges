using EdabitChallenges.Expert;
namespace EdabitChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("All challenges are ordered in difficulty level.");
            string[] hej = BuildingBinaryClock.BinaryClock("10:37:49");

            for (int i = 0; i < hej.Length; i++)
            {
                Console.WriteLine(hej[i]);
            }
            
        }
    }
}