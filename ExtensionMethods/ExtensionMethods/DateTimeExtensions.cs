using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns the difference between dates in years.
        /// </summary>
        /// <param name="birthDate"></param>
        /// <param name="referenceDate"></param>
        /// <returns>
        /// Age from given birthdate compared to reference date.
        /// </returns>
        public static int Age(this DateTime birthDate, DateTime referenceDate)
        {
            double daysBetween = (referenceDate - birthDate).TotalDays;
            if (daysBetween < 366)
            {
                return 0;
            }
            else if (daysBetween > 365)
            {
                return (int)daysBetween / 365;
            }
            else
                return 0;
        }
    }
}
