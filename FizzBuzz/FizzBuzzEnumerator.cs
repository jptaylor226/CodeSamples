using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    internal sealed class FizzBuzzEnumerator : IEnumerator<FizzBuzzItem>
    {
        private readonly IDictionary<int, string> _buzzwords;

        public FizzBuzzItem Current => throw new System.NotImplementedException();

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
