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
            var result = true;
            return result;
        }
        public static IEnumerable<long> Factors(this long value)
        {
            var factors = new ConcurrentQueue<long>(new[] { 1L, value });
            return factors.OrderBy(_ => _).Distinct();
        }
    }
}
