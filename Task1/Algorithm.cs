using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Algorithm
    {
        #region public
        public static int FindGCD(int a,int b,out long time)
        {
            long start = DateTime.Now.Ticks;
            int gcd = GCD(a, b);
            time = (DateTime.Now.Ticks - start)/TimeSpan.TicksPerMillisecond;
            return gcd;
        }
        public static int FindGCD(int a,int b,int c,out long time)
        {
            long start = DateTime.Now.Ticks;
            int gcd = GCD(GCD(a, b), c);
            time = (DateTime.Now.Ticks - start) / TimeSpan.TicksPerMillisecond;
            return gcd;
        }
        public static int FindGCD(out long time, params int[] numbers)
        {
            long start = DateTime.Now.Ticks;
            int gcd = numbers.Aggregate(GCD);
            time = (DateTime.Now.Ticks - start) / TimeSpan.TicksPerMillisecond;
            return gcd;
        }

        public static int FindBinaryGCD(int a,int b,out long time)
        {
            long start = DateTime.Now.Ticks;
            int gcd = BinaryGCD(a, b);
            time = (DateTime.Now.Ticks - start) / TimeSpan.TicksPerMillisecond;
            return gcd;
        }
        public static int FindBinaryGCD(int a, int b, int c,out long time)
        {
            long start = DateTime.Now.Ticks;
            int gcd = BinaryGCD(BinaryGCD(a, b), c);
            time = (DateTime.Now.Ticks - start) / TimeSpan.TicksPerMillisecond;
            return gcd;
        }
        public static int FindBinaryGCD(out long time,params int[] numbers)
        {
            long start = DateTime.Now.Ticks;
            int gcd = numbers.Aggregate(BinaryGCD);
            time = (DateTime.Now.Ticks - start) / TimeSpan.TicksPerMillisecond;
            return gcd;
        }
        #endregion
        #region private
        private static int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a == 0) return b;
            if (b == 0) return a;
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            return a;
        }
        private static int BinaryGCD(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a % 2 == 0 && b % 2 == 0) return 2 * BinaryGCD(a / 2, b / 2);
            if (a % 2 == 0 && b % 2 != 0) return BinaryGCD(a / 2, b);
            if (a % 2 != 0 && b % 2 == 0) return BinaryGCD(a, b / 2);
            return BinaryGCD(b, Math.Abs(a - b));
        }
        #endregion
    }
}
