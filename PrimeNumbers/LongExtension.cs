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
            var result = false;
            
            //value <=0 then it is not prime
            if (value <= 1)
            {
                return result;
            }

            if (value == 2 || value == 3)
            {
                return true;
            }

            var factors = Factors(value);
            if (factors.ToList().Count == 2)
            {
                result = true;
            }

            return result;
        }
        public static IEnumerable<long> Factors(this long value)
        {
            long valueToCheck = value / 2;
            for (long i = 2; i < valueToCheck; i++)
            {
                if ((value / i) == 0)
                {
                    return new ConcurrentQueue<long>();
                }
            }

            var factors = new ConcurrentQueue<long>(new[] { 1L, value });           

            return factors.OrderBy(_ => _).Distinct();
        }
    }
}
