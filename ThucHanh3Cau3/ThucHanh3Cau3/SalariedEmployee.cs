using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3Cau3
{
    class SalariedEmployee:Employee
    {
        private double salary;

        public SalariedEmployee(string name, int year, int month, int day, double salary)
         : base(name, year, month, day)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            double calcPay = CalcPay();
            return base.ToString()+ "\n" + string.Format("salary: {0} \nCalcPay {1}", salary, calcPay);
        }

        public override double CalcPay()
        {
            return salary / 24;
        }
    }
}
