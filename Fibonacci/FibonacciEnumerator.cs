using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    internal sealed class FibonacciEnumerator : IEnumerator<long>
    {
        private long _prior = 0;

        public long Current { get; set; }

        object IEnumerator.Current => new List<long>();

        public FibonacciEnumerator()
        {
            


        }



        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            return Current == 1;
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
