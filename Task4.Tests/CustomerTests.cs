using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Task4.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        [TestCase("Jeffrey Richter", "+1 (425) 555-0100",1000000,"nrp","de-DE",Result = "Customer record: Jeffrey Richter 1.000.000,00 € +1 (425) 555-0100")]
        public string ToString_Test(string name,string contactPhone,decimal revenue,string format,string culture)
        {
            IFormatProvider formatProvider = new CultureInfo(culture);
            Customer customer = new Customer(name, contactPhone, revenue);
            return "Customer record: " + customer.ToString(format,formatProvider);
        }

        [Test]
        [TestCase("Jeffrey Richter", "+1 (425) 555-0100", 1000000, "nrp", "de-DE", Result = "Customer record: Customer: Jeffrey Richter. Revenue: $1,000,000.00. Contact phone: +1 (425) 555-0100.")]
        public string ToString_TestCustom(string name, string contactPhone, decimal revenue, string format, string culture)
        {
            IFormatProvider formatProvider = new CustomFormatProvider();
            Customer customer = new Customer(name, contactPhone, revenue);
            Console.WriteLine("Customer record: " + customer.ToString(format, formatProvider));
            return "Customer record: " + customer.ToString(format, formatProvider);
        }
    }
}
