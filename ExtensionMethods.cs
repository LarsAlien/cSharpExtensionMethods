using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class ExtensionMethods
    {

        /// <summary>
        /// Removes and returns the last <typeparamref name="IList"/>&lt;<typeparamref name="T"/>&gt; item in collection
        /// </summary>
        public static T Pop<T>(this IList<T> list)
        {
            T value = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return value;
        }

        /// <summary>
        /// Removes and returns the <typeparamref name="IList"/>&lt;<typeparamref name="T"/>&gt; item at specified index
        /// </summary>
        public static T Pop<T>(this IList<T> list, int index)
        {
            T value = list[index];
            list.RemoveAt(index);
            return value;
        }

        /// <summary>Creates a <typeparamref name="List"/>&lt;<typeparamref name="int"/>&gt; from input sequence</summary>
        ///<returns>A list of elements from input sequence</returns>
        public static List<int> ToList(this int number)
        {
            return number.ToString().Select(i => Int32.Parse(i.ToString())).ToList();
        }
        /// <summary>Creates a <typeparamref name="List"/>&lt;<typeparamref name="int"/>&gt; from input sequence</summary>
        ///<returns>A list of elements from input sequence</returns>
        public static List<int> ToList(this long number)
        {
            return number.ToString().Select(i => Int32.Parse(i.ToString())).ToList();
        }

        /// <summary>
        /// Checks if number is in range (Including delimiters)
        /// </summary>
        public static bool InRange(this int thisNumber, int lower, int upper)
        {
            return thisNumber >= lower && thisNumber <= upper;
        }

        /// <summary>
        /// Check if substring occurs in fullstring at that specific order
        /// </summary>
        public static bool Occurs(this string fullstring, string substring)
        {
            string substringRegex = "";
            foreach (char c in substring) substringRegex += c + ".*";

            return Regex.IsMatch(fullstring, substringRegex);
        }
    }
}
