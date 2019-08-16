using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class Palindromes
    {
        public static bool IsPalindrome(this string value, bool caseSensitive = false)
        {
            if (string.IsNullOrEmpty(value) == false)
            { 
                value = value.Replace(" ", "");
                value = value.Replace(",", "");
                value = value.Replace("'", "");
                value = value.Replace("!", "");
                if (caseSensitive == false)
                    value = value.ToLower();
            }
            var result = false;
            if (value == null) return false;
            Char[] myArray = value.ToCharArray();
            int iLeng = value.Length;
            int MatchCount = 0;

     
            for(int i=0; i< iLeng/2; i++)
            {
                if (myArray[i] == myArray[iLeng - (i+1) ])
                    MatchCount++;

            }

            if (MatchCount == iLeng / 2)
                result = true;

            return result;
        }
    }
}
