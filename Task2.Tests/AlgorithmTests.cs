using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Task2.Tests
{
    [TestFixture]
    public class AlgorithmTests
    {
        [Test]
        [TestCase(1,2, Result = 1)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(1, 0, Result = 1)]
        [TestCase(0, 2, Result = 2)]
        [TestCase(8, 16, Result = 8)]
        public int FindGCD_for2(int a,int b)
        {
            long time;
            return Task2.Algorithm.FindGCD(a, b,out time);
        }

        [Test]
        [TestCase(1, 2, 3, Result = 1)]
        [TestCase(0, 2, 3, Result = 1)]
        [TestCase(0, 0, 0, Result = 0)]
        [TestCase(0, 0, 3, Result = 3)]
        public int FindGCD_for3(int a, int b,int c)
        {
            long time;
            return Task2.Algorithm.FindGCD(a, b, c, out time);
        }

        [Test]
        [TestCase(1, 2, 3, 4, Result = 1)]
        [TestCase(0, 2, 3, 4, Result = 1)]
        [TestCase(0, 0, 0, 0, Result = 0)]
        [TestCase(0, 0, 0, 3, Result = 3)]
        public int FindGCD_forn(int a, int b, int c,int d)
        {
            long time;
            return Task2.Algorithm.FindGCD(out time,a,b,c,d);
        }

        [Test]
        [TestCase(1, 2, Result = 1)]
        [TestCase(0, 0, Result = 0)]
        [TestCase(1, 0, Result = 1)]
        [TestCase(0, 2, Result = 2)]
        [TestCase(8, 16, Result = 8)]
        public int BinaryFindGCD_for2(int a, int b)
        {
            long time;
            return Task2.Algorithm.FindBinaryGCD(a, b, out time);
        }

        [Test]
        [TestCase(1, 2, 3, Result = 1)]
        [TestCase(0, 2, 3, Result = 1)]
        [TestCase(0, 0, 0, Result = 0)]
        [TestCase(0, 0, 3, Result = 3)]
        public int BinaryFindGCD_for3(int a, int b, int c)
        {
            long time;
            return Task2.Algorithm.FindBinaryGCD(a, b, c, out time);
        }

        [Test]
        [TestCase(1, 2, 3, 4, Result = 1)]
        [TestCase(0, 2, 3, 4, Result = 1)]
        [TestCase(0, 0, 0, 0, Result = 0)]
        [TestCase(0, 0, 0, 3, Result = 3)]
        public int BinaryFindGCD_forN(int a, int b, int c, int d)
        {
            long time;
            return Task2.Algorithm.FindBinaryGCD(out time, a, b, c, d);
        }
    }
}
