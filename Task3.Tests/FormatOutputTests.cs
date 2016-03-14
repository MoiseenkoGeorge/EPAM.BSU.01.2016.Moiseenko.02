using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task3.Tests
{
    [TestFixture]
    public class FormatOutputTests
    {
        [Test]
        [TestCase(16, Result = "10")]
        [TestCase(15, Result = "F")]
        [TestCase(0, Result = "0")]
        [TestCase(1022, Result = "3FE")]
        [TestCase(123, Result = "7B")]
        [TestCase(1, Result = "1")]
        [TestCase(10, Result = "A")]
        [TestCase(-1, ExpectedException = typeof(ArgumentOutOfRangeException))]
        public string FormatOutputOfNumber(int number)
        {
            return number.ConvertTo16Hex();
        }
    }
}
