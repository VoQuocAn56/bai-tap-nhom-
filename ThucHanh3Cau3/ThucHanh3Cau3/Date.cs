using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3Cau3
{
    class Date
    {
        int year;
        int month;
        int day;

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string DisplayStat()
        {
            return string.Format("year: {0}, month: {1}, day: {2}", new object[] { year, month, day });
        }
    }
}
