using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
    public sealed class FizzBuzzFactory : IEnumerable<FizzBuzzItem>
    {
        private readonly IDictionary<int, string> _buzzwords = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        public IEnumerator<FizzBuzzItem> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public void SetBuzzwords(IDictionary<int, string> buzzwords)
        {
            _buzzwords.Clear();
            foreach (var pair in buzzwords)
            {
                _buzzwords.Add(pair.Key, pair.Value);
            }
        }
    }
}
