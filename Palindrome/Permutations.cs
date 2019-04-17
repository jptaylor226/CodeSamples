using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringExtensions
{
    public static class Permutations
    {
        public static IEnumerable<string> Permute(this string value)
        {
            if (value == null || value.Length == 0) return new List<string>();
            if (value.Length == 1) return new[] { value };


            var result = new List<string>();
            for(var i = 0; i < value.Length; i++)
            {
                var left = i == 0 ? string.Empty : value.Substring(0, i);
                var right = i == value.Length - 1 ? string.Empty : value.Substring(i + 1);
                var others = $"{left}{right}";
                result.AddRange(others.Permute().Select(_ => $"{value.Substring(i, 1)}{_}"));
            }
            return result;
        }
    }
}
