using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    public static class LongExtension
    {
        public static bool IsPrime(this long value)
        {
            if (value < 2) return false;
            if (value == 2) return true;
            if (value % 2 == 0) return false;

            var result = true;
            var squareRoot = (long)Math.Sqrt(value);
            for (long i = 3; result && i <= squareRoot; i += 2)
            {
                result = value % i != 0;
            }
            return result;
        }
        public static IEnumerable<long> Factors(this long value)
        {
            if (value < 2) return new List<long>();
            var result = new List<long>{1};
            var squareRoot = (long)Math.Sqrt(value);
            for (long i = 2; i <= squareRoot; i ++)
            {
                if (value % i == 0) result.Add(i);
            }
            result.Add(value);
            return result;
        }
    }
}
