using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3Cau3
{
    class Address
    {
        private string street;
        private string city;

        public Address(string street, string city)
        {
            this.street = street;
            this.city = city;
        }

        public string DisplayStat()
        {
            return string.Format("street: {0}, city: {1}", street, city);
        }
    }
}
