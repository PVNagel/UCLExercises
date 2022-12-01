using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public delegate double BonusProvider(double amount);

    public class Bonuses
    {
        public static double TenPercent(double amount)
        {
            double result = amount * 0.10;
            return result;
        }

        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            double result;

            if (amount > 5)
            {
                result = 2.0;
                return result;
            }

            else
            {
                result = 0.0;
                return result;
            }
        }
    }
}
