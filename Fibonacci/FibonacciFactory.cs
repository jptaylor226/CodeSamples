using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciFactory : IEnumerable<long>
    {
        public IEnumerator<long> GetEnumerator()
        {
            return new FibonacciEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
