using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.VeryEasy
{
    // Frames Per Second: https://edabit.com/challenge/jX2Hjsk5Xf6T3qdur
    public static class FramesPerSecond
    {
        public static int Frames(int minutes, int fps) => (minutes * 60) * fps;
    }
}
