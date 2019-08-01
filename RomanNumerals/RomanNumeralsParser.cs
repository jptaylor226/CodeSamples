using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RomanNumerals
{
    public class RomanNumeralsParser : INumeralsParser
    {
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
            return result;
        }
    }
}
