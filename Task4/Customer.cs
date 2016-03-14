using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Customer : IFormattable
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

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (format == null)
                throw new ArgumentNullException(nameof(format), "Require not null argument");
            if (formatProvider == null)
                formatProvider = CultureInfo.CurrentCulture;
            return string.Format(formatProvider, format, Name, ContactPhone, Revenue); // {0} - Name, {1} - ContactPhone, {2} - Revenue
        }
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.CurrentCulture);
        }
    }
}
