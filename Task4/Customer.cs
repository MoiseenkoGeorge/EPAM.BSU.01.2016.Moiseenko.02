using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Customer
    {
        public string Name { get; private set; }
        public string ContactPhone { get; private set; }
        public decimal Revenue { get; private set; }

        public Customer(string name,string contactPhone,decimal revenue)
        {
            this.Name = name;
            this.ContactPhone = contactPhone;
            this.Revenue = revenue;
        }
    }
}
