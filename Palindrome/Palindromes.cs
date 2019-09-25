using System;
using System.Text.RegularExpressions;

namespace StringExtensions
{
    public static class Palindromes
    {
        public static bool IsPalindrome(this string value, bool caseSensitive = false)
        {
            if (value == null) return false;
            if (value == "") return true;


            var len = value.Length -1;
            var str = value;
            if (caseSensitive == false)
            {
                str = value.ToLower();
            }

            for(var i =0; i < len/2; i++)
            {                
                if (str[i] != str[len - i])
                {
                    return false;
                }
            }

            var result = true;
            return result;
        }
    }
}
