using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions {
    public static class ListExtensions {
        // Selects a random item from the list and returns it
        public static T GetRandomListItem<T>(this List<T> list) {
            if (list.Count == 0) {
                throw new System.IndexOutOfRangeException("Cannot select a random item from an empty list");
            }
            return list[Random.Range(0, list.Count)];
        }

        // Removes a random item from the list and returns it
        public static T RemoveRandomListItem<T>(this List<T> list) {
            if (list.Count == 0) {
                throw new System.IndexOutOfRangeException("Cannot remove a random item from an empty list");
            }

            int index = Random.Range(0, list.Count);
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }

        // Returns a new shuffled list
        public static List<T> Shuffle<T>(this List<T> list) {
            if (list.Count == 0) {
                throw new System.IndexOutOfRangeException("Cannot shuffle an empty list");
            }

            List<T> newList = new List<T>();
            int count = list.Count;

            for (int i = 0; i < count; i++) {
                T item = list[Random.Range(0, list.Count)];
                list.Remove(item);
                newList.Add(item);
            }

            return newList;
        }
    }
}
