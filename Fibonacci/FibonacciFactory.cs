using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    public class FibonacciFactory : IEnumerable<long>
    {
        
 
        public IEnumerator<long> GetEnumerator()
        {
            IEnumerator<long> fibonacciEnumerator = new FibonacciEnumerator();
                       
            return fibonacciEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new FibonacciEnumerator();
        }
       
    }
}
