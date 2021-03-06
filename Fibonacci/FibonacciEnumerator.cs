﻿using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
    internal sealed class FibonacciEnumerator : IEnumerator<long>
    {
        private long _prior = 0;
        public long Current { get; private set; } = 0;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            // No depedencies on external resources
        }

        public bool MoveNext()
        {
            var next = _prior + Current;
            _prior = Current;
            Current = next == 0 ? 1 : next;
            return true;
        }

        public void Reset()
        {
            _prior = 0;
            Current = 1;
        }
    }
}
