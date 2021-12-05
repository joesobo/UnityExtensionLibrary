using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class StringExtensions {
        // Returns a portion of the given string
        public static string Truncate(this string value, int maxLength) {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        // Returns a portion of the given string
        public static string Truncate(this string value, int minLength, int maxLength) {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength && value.Length >= minLength ? value : value.Substring(minLength, maxLength - 1);
        }

        // Prints a formatted line with arguments to the console
        // EX: Print("(x={0}, y={1}, z={2})", x, y, z);
        public static void Print(string fmt, params object[] args) {
            Debug.Log(string.Format(fmt, args));
        }

        // Prints an unformatted string
        public static void Print<T>(T value) {
            Debug.Log(value);
        }

        // Quick command for formatting string
        // EX: "Hello {0}".With("Joe");
        public static string With(this string s, params object[] args) {
            return string.Format(s, args);
        }
    }
}
