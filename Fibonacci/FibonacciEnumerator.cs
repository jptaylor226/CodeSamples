﻿using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    internal sealed class FibonacciEnumerator : IEnumerator<long>
    {
        private long _prior = 0;

        public long Current => throw new System.NotImplementedException();

        object IEnumerator.Current => throw new System.NotImplementedException();

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new System.NotImplementedException();
        }

        public void Reset()
        {
            throw new System.NotImplementedException();
        }
    }
}
