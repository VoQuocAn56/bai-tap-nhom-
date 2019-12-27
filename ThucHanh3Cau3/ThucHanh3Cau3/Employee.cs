using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3Cau3
{
    abstract class Employee
    {
        private string name;
        private Address address;
        private Date date;

        public Employee(string name, int year, int month, int day)
        {
            this.name = name;
            date = new Date(year, month, day);
        }

        ~Employee()
        {
            date = null;
        }

        public abstract double CalcPay();

        public void SetAddress(string street, string city)
        {
            address = new Address(street, city);
        }

        public override string ToString()
        {
            return string.Format("\nName: {0}, \nAddress: {1}, \nDate: {2}", new object[] { name, address.DisplayStat(), date.DisplayStat() });
        }
    }
}
