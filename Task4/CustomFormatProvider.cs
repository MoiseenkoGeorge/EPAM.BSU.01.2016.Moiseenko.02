using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class CustomFormatProvider : IFormatProvider, ICustomFormatter
    {
        private IFormatProvider parentFormatProvider;
        public CustomFormatProvider() : this(null)
        {
        }
        public CustomFormatProvider(IFormatProvider parentFormatProvider)
        {
            if (parentFormatProvider == null)
                this.parentFormatProvider = CultureInfo.CurrentCulture;
            else this.parentFormatProvider = parentFormatProvider;
        }
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (format == null)
                return arg.ToString();
            switch(format.ToUpper())
            {
                case "N":
                    return "Customer: " + arg.ToString() + ".";
                case "P":
                    return "Contact phone: " + arg.ToString() + ".";
                case "R":
                    return "Revenue: " + string.Format(parentFormatProvider, "{0:C}", arg) + ".";
                default:
                    return string.Format(parentFormatProvider, "{0:" + format + "}", arg);
            }
        }

        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }
    }
}
