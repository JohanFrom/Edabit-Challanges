using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdabitChallenges.Hard
{
    // Add Dollar Bills: https://edabit.com/challenge/RrPW2X9Bkbkr4FLWD
    public static class AddDollarBills
    {
        public static int AddBill(string money)
        {
            var moneyInDollars = money.Split(",").Where(x => x.Contains('$')).Select(x => x.Replace("$", "").Trim());
            int dollars = 0;

            foreach(string d in moneyInDollars)
            {
                dollars += d.Contains('k') ? int.Parse(d.Remove(d.IndexOf('k')) + "000") : int.Parse(d); ;
            }

            return dollars;
        }
    }
}
