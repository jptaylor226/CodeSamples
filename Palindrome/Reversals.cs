using System;
using System.Collections.Generic;
using System.Text;

namespace StringExtensions
{
    public static class Reversals
    {
        public static string Reverse(this string value)
        {
            if (value == null) return value;
            var characters = value.ToCharArray().Reverse();
            return new string(characters);
        }
        public static string ReverseSentence(this string value)
        {
            if (value == null) return value;
            var words = value.Split(' ');
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendJoin(' ', words.Reverse());
            return stringBuilder.ToString();
        }
        public static T[] Reverse<T>(this T[] values)
        {
            if (values == null || values.Length < 2) return values;
            var result = new T[values.Length];
            values.CopyTo(result, 0);
            var end = result.Length - 1;
            for (var i = 0; i < end; i++, end--)
            {
                var temp = result[i];
                result[i] = result[end];
                result[end] = temp;
            }
            return result;
        }
    }
}
