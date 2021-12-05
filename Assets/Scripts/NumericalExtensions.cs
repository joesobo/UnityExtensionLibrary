using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class NumericalExtensions {
        // Remaps a value to a new range, keeping a linear value along range
        // EX: 0.5 in 0-1 gets converted to 50 in 0-100
        public static float LinearRemap(this float value, float minValue, float maxValue, float minNew, float maxNew) {
            return (value - minValue) / (maxValue - minValue) * (maxNew - minNew) + minNew;
        }

        // Gives value a random positive or negative sign
        public static int WithRandomSign(this int value, float negativeProbability = 0.5f) {
            return Random.value < negativeProbability ? -value : value;
        }

        // Gives result of a probability
        // EX: RandomProbability(33) = 33% chance of True
        public static bool RandomProbability(float percentage) {
            return (Random.Range(0, 100) < percentage);
        }

        // Returns a squared float
        public static float Squared(this float value) {
            return Mathf.Pow(value, 2);
        }

        // Returns a squared float
        public static float Squared(this int value) {
            return Mathf.Pow(value, 2);
        }

        // Returns a cubed float
        public static float Cubed(this float value) {
            return Mathf.Pow(value, 3);
        }

        // Returns a cubed float
        public static int Cubed(this int value) {
            return (int)Mathf.Pow(value, 3);
        }

        // Divides 2 integers and stores the result and remainder
        // EX: Divide(10, 3, out int res, out int rem);
        public static void Divide(int x, int y, out int result, out int remainder) {
            result = x / y;
            remainder = x % y;
        }

        // Divides 2 floats and stores the result and remainder
        // EX: Divide(10f, 3f, out float res, out float rem);
        public static void Divide(float x, float y, out float result, out float remainder) {
            result = x / y;
            remainder = x % y;
        }

        // Returns true if the value is between the high and low (inclusively)
        public static bool IsBetween(this float actual, float low, float high) {
            return Mathf.Abs(actual) >= Mathf.Abs(low) && Mathf.Abs(actual) <= Mathf.Abs(high);
        }

        // Swaps the references for 2 integers
        public static void Swap(ref int x, ref int y) {
            int temp = x;
            x = y;
            y = temp;
        }

        // Swaps the references for 2 floats
        public static void Swap(ref float x, ref float y) {
            float temp = x;
            x = y;
            y = temp;
        }
    }
}
