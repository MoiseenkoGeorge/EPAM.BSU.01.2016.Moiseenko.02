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
                formatProvider = CultureInfo.InvariantCulture;
            switch(format.ToUpperInvariant())
            {
                case "NRP":
                    if(formatProvider is CustomFormatProvider)
                        return string.Format(formatProvider, "{0:N} {1:R} {2:P}", Name, Revenue, ContactPhone);
                    return string.Format(formatProvider, "{0} {1:C} {2}", Name, Revenue, ContactPhone);
                case "NR":
                    if (formatProvider is CustomFormatProvider)
                        return string.Format(formatProvider, "{0:N} {1:R}", Name, Revenue);
                    return string.Format(formatProvider, "{0} {1:C}", Name, Revenue);
                case "G":
                    return string.Format(formatProvider, "{0}", Name);
                case "R":
                    if (formatProvider is CustomFormatProvider)
                        return string.Format(formatProvider, "{0:R}", Revenue);
                    return string.Format(formatProvider, "{0}", Revenue);
                default:
                    throw new FormatException(String.Format("The {0} format string is not supported.", format));

            }

        }
        public string ToString(string format)
        {
            return this.ToString(format, CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
