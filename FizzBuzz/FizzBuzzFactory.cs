using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzz
{
    public sealed class FizzBuzzFactory : IEnumerable<FizzBuzzItem>
    {
        public IDictionary<int, string> _buzzwords = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        public IEnumerator<FizzBuzzItem> GetEnumerator()
        {
            return new FizzBuzzEnumerator(_buzzwords);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
