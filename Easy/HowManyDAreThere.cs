using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Easy
{
    // How Many D's Are There?: https://edabit.com/challenge/YxoGXwpApf9De7y5w
    public static class HowManyDAreThere
    {
        public static int CountDs(string str) => str.ToLower().Count(c => c == 'd');
    }
}
