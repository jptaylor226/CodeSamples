using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            Parallel.For(1, (squareRoot + 1) / 2, (i, state) =>
                {
                    if  (value % ((i << 1) | 1) == 0)
                    {
                        result = false;
                        state.Break();
                    }
                });
            return result;
        }
        public static IEnumerable<long> Factors(this long value)
        {
            if (value < 2) return new List<long>();
            var squareRoot = (long)Math.Sqrt(value);
            var factors = new ConcurrentQueue<long>(new[] { 1L, value });
            Parallel.For(2, squareRoot + 1, (i) =>
            {
                if (value % i == 0)
                {
                    factors.Enqueue(i);
                    factors.Enqueue(value / i);
                }
            });

            return factors.OrderBy(_ => _).Distinct();
        }
    }
}
