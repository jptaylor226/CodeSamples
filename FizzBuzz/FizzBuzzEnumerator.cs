using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    internal sealed class FizzBuzzEnumerator : IEnumerator<FizzBuzzItem>
    {
        private readonly IDictionary<int, string> _buzzwords;

        public FizzBuzzItem Current { get; private set; }

        object IEnumerator.Current => Current;

        public FizzBuzzEnumerator(IDictionary<int, string> buzzwords)
        {
            _buzzwords = buzzwords;
        }
        public void Dispose()
        {
            Current = null;
        }

        public bool MoveNext()
        {
            if (Current == null)
            {
                Current = new FizzBuzzItem { Value = 0 };
            }
            Current = new FizzBuzzItem
            {
                Value = Current.Value + 1,
            };
            Current.Parsed = 
                string.Concat(_buzzwords.Keys.Where(_ => Current.Value % _ == 0).Select(_ => _buzzwords[_]));
            if (string.IsNullOrEmpty(Current.Parsed)) Current.Parsed = Current.Value.ToString();
            return true;    
        }

        public void Reset()
        {
            Current = null;
        }
    }
}
