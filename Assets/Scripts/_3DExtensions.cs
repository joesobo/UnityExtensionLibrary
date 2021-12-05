using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class _3DExtensions {
        // Returns if a point is inside the radius
        public static bool IsInsideRadius(this Vector3 point, Vector3 origin, float radius = 2) {
            return Mathf.Pow(point.x - origin.x, 2) + Mathf.Pow(point.y - origin.y, 2) + Mathf.Pow(point.z - origin.z, 2) < Mathf.Pow(radius, 2);
        }

        // Returns a random position in a radius
        public static Vector3 RandomPosition(float radius = 2) {
            return Random.onUnitSphere * radius;
        }

        // Returns a random position between 2 radii
        public static Vector3 RandomPositionBetweenRadii(float minRadius, float maxRadius) {
            float rand = Random.Range(minRadius, maxRadius);
            return RandomPosition(rand);
        }

        // Sets the X value of a vector
        public static Vector3 SetX(this Vector3 vector, float x) {
            return new Vector3(x, vector.y, vector.z);
        }

        // Sets the Y value of a vector
        public static Vector3 SetY(this Vector3 vector, float y) {
            return new Vector3(vector.x, y, vector.z);
        }

        // Sets the Z value of a vector
        public static Vector3 SetZ(this Vector3 vector, float z) {
            return new Vector3(vector.x, vector.y, z);
        }

        // Adds the X value to a vector
        public static Vector3 AddX(this Vector3 vector, float x) {
            return new Vector3(vector.x + x, vector.y, vector.z);
        }

        // Adds the Y value to a vector
        public static Vector3 AddY(this Vector3 vector, float y) {
            return new Vector3(vector.x, vector.y + y, vector.z);
        }

        // Adds the Z value to a vector
        public static Vector3 AddZ(this Vector3 vector, float z) {
            return new Vector3(vector.x, vector.y, vector.z + z);
        }

        // Converts Vector3 to Vector2
        public static Vector2 ConvertToVector2(this Vector3 v) {
            return new Vector2(v.x, v.y);
        }
    }
}
