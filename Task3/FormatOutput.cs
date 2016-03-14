using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class FormatOutput
    {
        public static string ConvertTo16Hex(this int number)
        {
            return string.Format("{0:x}".ToUpper(), number);
        }
    }
}
