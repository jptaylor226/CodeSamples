using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciFactory : IEnumerable<long>
    {
        public IEnumerator<long> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
