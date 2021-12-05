using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class BasicExtensions {
        // Resets the transform
        public static void ResetTransform(this Transform trans) {
            trans.position = Vector3.zero;
            trans.localRotation = Quaternion.identity;
            trans.localScale = Vector3.one;
        }

        // Resets the transform of all children
        public static void ResetChildTransform(this Transform trans, bool recursive = false) {
            foreach (Transform child in trans) {
                child.ResetTransform();

                if (recursive) {
                    child.ResetChildTransform(recursive);
                }
            }
        }

        // Sets the layer for a children
        public static void SetChildLayers(this Transform trans, string layerName, bool recursive = false) {
            var layer = LayerMask.NameToLayer(layerName);
            foreach (Transform child in trans) {
                child.gameObject.layer = layer;

                if (recursive) {
                    child.SetChildLayers(layerName, recursive);
                }
            }
        }

        // Returns whether or not GameObject has component
        public static bool HasComponent<T>(this GameObject gameObject) where T : Component {
            return gameObject.GetComponent<T>() != null;
        }

        // Finds the component if it is attached, otherwise attaches it
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component {
            if (gameObject.GetComponent<T>() != null) {
                return gameObject.GetComponent<T>();
            }
            return gameObject.AddComponent<T>();
        }

        // Destroys all children attached to the GameObject
        public static void DestroyChildren(this GameObject parent) {
            List<Transform> children = new List<Transform>();
            for (int i = 0; i < parent.transform.childCount; i++) {
                children.Add(parent.transform.GetChild(i));
            }
            for (int i = 0; i < children.Count; i++) {
                GameObject.Destroy(children[i].gameObject);
            }
        }

        // Calculates if something is visible from the camera's point of view
        public static bool isVisibleFrom(this Renderer renderer, Camera camera) {
            var planes = GeometryUtility.CalculateFrustumPlanes(camera);
            return GeometryUtility.TestPlanesAABB(planes, renderer.bounds);
        }

        // Returns a normalized direction from start point to end point
        public static Vector3 GetDirection(Vector3 startPoint, Vector3 endPoint) {
            return (endPoint - startPoint).normalized;
        }
    }
}
