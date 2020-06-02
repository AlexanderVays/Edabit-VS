using System;
using System.Collections.Generic;
using System.Text;

namespace Edabit
{
    class Dates
    {
        //returns the number of days in a specific year and month
        public static int Days(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }

        //returns a specific month according the number --- 1 = January
        public static string MonthName(int num)
        {
            DateTime date = new DateTime(2020, num, 10);
            return date.ToString("MMMM");
        }
    }
}
