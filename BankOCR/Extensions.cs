using System;
using System.Collections.Generic;
using System.Linq;

namespace BankOCR
{
    public static class Extensions
    {
        public static string AsString(this IEnumerable<char> source)
        {
            return new string(source.ToArray());
        }
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> a)
        {
            foreach (var t in source)
            {
                a(t);
            }
        }
    }
}