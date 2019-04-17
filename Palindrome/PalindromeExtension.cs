using System;
using System.Text.RegularExpressions;

namespace PalindromeNS
{
    public static class PalindromeExtension
    {
        public static bool IsPalindrome(this string value, bool caseSensitive = false)
        {
            if (value == null) return false;
            var result = true;
            var normalized = Regex.Replace(value, @"[^\w]", string.Empty);
            var characters = caseSensitive ? normalized.ToCharArray() : normalized.ToUpper().ToCharArray();
            for(var i = 0; result && i < characters.Length/2; i++)
            {
                result = characters[i] == characters[characters.Length - i - 1];
            }
            return result;
        }
    }
}
