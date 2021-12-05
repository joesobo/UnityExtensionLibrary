using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class _2DExtensions {
        // Rotates a vector by a number of degrees
        public static Vector2 Rotate(this Vector2 v, float degrees) {
            return Quaternion.Euler(0, 0, degrees) * v;
        }

        // Converts rotation to degrees
        public static float RotationNormalizedDegree(this float rotation) {
            rotation %= 360;
            if (rotation <= 0) {
                rotation = 0;
            }
            return rotation;
        }

        // Sets the X value of a vector
        public static Vector2 SetX(this Vector2 vector, float x) {
            return new Vector2(x, vector.y);
        }

        // Sets the Y value of a vector
        public static Vector2 SetY(this Vector2 vector, float y) {
            return new Vector2(vector.x, y);
        }

        // Adds the X value to a vector
        public static Vector2 AddX(this Vector2 vector, float x) {
            return new Vector2(vector.x + x, vector.y);
        }

        // Adds the Y value to a vector
        public static Vector2 AddY(this Vector2 vector, float y) {
            return new Vector2(vector.x, vector.y + y);
        }

        // Converts a Vector2 into a Vector3
        public static Vector3 ConvertToVector3(this Vector2 vector, float z) {
            return new Vector3(vector.x, vector.y, z);
        }
    }
}
