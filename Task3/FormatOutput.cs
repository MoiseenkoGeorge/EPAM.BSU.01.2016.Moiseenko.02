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
            if (number < 0)
                throw new ArgumentOutOfRangeException(nameof(number), "Require positive number");
            string output = "";
            int divider = 1;
            while (number / divider > 15)
                divider *= 16;
            while (divider>=1)
            {
                output += (number / divider) < 10 ? (char)('0' + number / divider) : (char)('A' + (number / divider) - 10);
                number %= divider;
                divider /= 16;
            }
            return output;
        }
    }
}
