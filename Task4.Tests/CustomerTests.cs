using System;
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
        [TestCase("Jeffrey Richter", "+1 (425) 555-0100",100000,"Customer record: {0}, {2}, {1}",Result = "Customer record: Jeffrey Richter, 100000, +1 (425) 555-0100")]
        [TestCase("Jeffrey Richter", "+1 (425) 555-0100", 100000, "Customer record: {1}", Result = "Customer record: +1 (425) 555-0100")]
        [TestCase("Jeffrey Richter", "+1 (425) 555-0100", 100000, null, ExpectedException = typeof(ArgumentNullException))]
        [TestCase("Jeffrey Richter", "+1 (425) 555-0100", 100000, "Customer record: {0}, {2}", Result = "Customer record: Jeffrey Richter, 100000")]
        public string ToString_Test(string name,string contactPhone,decimal revenue,string format)
        {
            Customer customer = new Customer(name, contactPhone, revenue);
            return customer.ToString(format);
        }
    }
}
