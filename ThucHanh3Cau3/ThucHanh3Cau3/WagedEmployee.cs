using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3Cau3
{
    class WagedEmployee:Employee
    {
        private double wage;
        private double hours;

        public WagedEmployee(string name, int year, int month, int day, double wage, double hours)
            : base(name, year, month, day)
        {
            this.wage = wage;
            this.hours = hours;
        }

        public override double CalcPay()
        {
            return wage * hours;
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + string.Format("wage: {0}, hours: {1}, CalcPay: {2}",
                                                 new object[] { wage, hours, CalcPay() });
        }
    }
}
