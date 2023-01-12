using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Tower of Hanoi: https://edabit.com/challenge/3ZtykTsx3GSoPHyBb
    public static class TowerOfHanoi
    {
        public static int Count { get; set; }
        public static int TowerHanoi(int num)
        {
            if(num == 0)
                return 0;
            else if(num == 1)  
                return 1;
            
            TowerHanoiCalc(num, 'A', 'C', 'B');
            return Count;
        }

        public static void TowerHanoiCalc(int n, char from_rod, char to_rod, char aux_rod)
        {
            if (n == 1)
            {
                Count++;
                return;
            }

            TowerHanoiCalc(n - 1, from_rod, aux_rod, to_rod);
            Count++;
            TowerHanoiCalc(n - 1, aux_rod, to_rod, from_rod);
        }


    }
}
