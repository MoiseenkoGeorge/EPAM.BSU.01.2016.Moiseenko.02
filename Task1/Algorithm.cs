using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task2
{
    public static class Algorithm
    {
        #region public
        #region simple
        public static int FindGCD(int a,int b,out double time)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int gcd = GCD(a, b);
            time = sw.Elapsed.TotalMilliseconds;
            return gcd;
        }
        public static int FindGCD(int a, int b) => GCD(a, b);
        public static int FindGCD(int a,int b,int c,out double time) => GCD(GCD, a, b, c, out time);
        public static int FindGCD(int a, int b, int c) => GCD(GCD, a, b, c);
        public static int FindGCD(out double time, params int[] numbers) => GCD(GCD, out time, numbers);
        public static int FindGCD(params int[] numbers) => GCD(GCD, numbers);
        #endregion
        #region binary
        public static int BinaryFindGCD(int a,int b,out double time)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int gcd = BinaryGCD(a, b);
            time = sw.Elapsed.TotalMilliseconds;
            return gcd;
        }
        public static int BinaryFindGCD(int a, int b) => BinaryGCD(a, b);
        public static int BinaryFindGCD(int a, int b, int c, out double time) => GCD(BinaryGCD, a, b, c, out time);
        public static int BinaryFindGCD(int a, int b, int c) => GCD(BinaryGCD, a, b, c);
        public static int BinaryFindGCD(out double time, params int[] numbers) => GCD(BinaryGCD, out time, numbers);
        public static int BinaryFindGCD(params int[] numbers) => GCD(BinaryGCD, numbers);
        #endregion
        #endregion
        #region private
        private static int GCD(Func<int, int, int> function,out double time, params int[] numbers)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int gcd = GCD(function, numbers);
            time = sw.Elapsed.TotalMilliseconds;
            return gcd;
        }
        private static int GCD(Func<int, int, int> function, params int[] numbers) => numbers.Aggregate(function);
        private static int GCD(Func<int, int, int> function, int a, int b, int c,out double time)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int gcd = GCD(function, a, b, c);
            time = sw.Elapsed.TotalMilliseconds;
            return gcd;
        }
        private static int GCD(Func<int, int, int> function, int a, int b, int c) => function(function(a, b), c);
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
