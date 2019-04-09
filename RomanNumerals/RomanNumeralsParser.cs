using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RomanNumerals
{
    public class RomanNumeralsParser : INumeralsParser
    {
        private static readonly Regex _regex = new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|IL|L?X{0,3})(IX|IV|V?I{0,3})$");
        private static readonly IDictionary<char, int> _romanDigits = new Dictionary<char, int>()
        {
            {'M', 1000},
            {'D',  500},
            {'C',  100},
            {'L',   50},
            {'X',   10},
            {'V',    5},
            {'I',    1},
        };
        public int Value(string input)
        {
            var result = 0;
            if (input != null && _regex.IsMatch(input))
            {
                var digits = input.ToCharArray();
                result = digits
                    .Select((t, i) => (i < digits.Length - 1 && _romanDigits[t] < _romanDigits[digits[i + 1]]) ? -_romanDigits[t] : _romanDigits[t])
                    .Sum();
            }

            return result;
        }
    }
}
