using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class Reversals
    {
        public static string Reverse(this string value)
        {
            string retVal = String.Empty;

            if (string.IsNullOrEmpty(value) == false)
            {
                char[] myArrray = value.ToCharArray();

                for (int i = value.Length - 1; i >= 0; i--)
                {
                    retVal += myArrray[i].ToString();
                }
            }
            else
            {
                return null;
            }
        

            return retVal;
        }
        public static string ReverseSentence(this string value)
        {
            return null;
        }
        public static T[] Reverse<T>(this T[] values)
        {
            var result = new T[values.Length];
            return result;
        }
    }
}
