using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    internal class FizzBuzzEnumerator : IEnumerator<FizzBuzzItem>
    {
        private readonly IDictionary<int, string> _buzzwords;
        private FizzBuzzItem _current;
        public FizzBuzzItem Current => _current;

        object IEnumerator.Current => _current;

        public FizzBuzzEnumerator(IDictionary<int, string> buzzwords)
        {
            _buzzwords = buzzwords;
        }
        public void Dispose()
        {
            _current = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = new FizzBuzzItem { Value = 0 };
            }
            _current = new FizzBuzzItem
            {
                Value = _current.Value + 1,
            };
            _current.Parsed = 
                string.Concat(_buzzwords.Keys.Where(_ => _current.Value % _ == 0).Select(_ => _buzzwords[_]));
            if (string.IsNullOrEmpty(_current.Parsed)) _current.Parsed = _current.Value.ToString();
            return true;    
        }

        public void Reset()
        {
            _current = null;
        }
    }
}
