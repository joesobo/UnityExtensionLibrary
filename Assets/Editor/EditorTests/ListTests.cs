using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine.TestTools;
using static Extensions.ListExtensions;

public class ListTests {
    [Test]
    public void getRandomListItemTest() {
        UnityEngine.Random.seed = 0;
        List<int> list = new List<int>();
        for (int i = 0; i < 10; i++) {
            list.Add(i);
        }

        int result = list.GetRandomListItem();

        Assert.AreEqual(6, result);
    }

    [Test]
    public void badRandomListItemTest() {
        UnityEngine.Random.seed = 0;
        List<int> list = new List<int>();

        try {
            int result = list.GetRandomListItem();
        } catch (Exception e) {
            Assert.IsTrue(e != null);
        }
    }

    [Test]
    public void removeRandomListItemTest() {
        UnityEngine.Random.seed = 0;
        List<int> list = new List<int>();
        for (int i = 0; i < 10; i++) {
            list.Add(i);
        }

        int result = list.RemoveRandomListItem();

        Assert.AreEqual(6, result);
    }

    [Test]
    public void removeBadRandomListItemTest() {
        UnityEngine.Random.seed = 0;
        List<int> list = new List<int>();

        try {
            int result = list.RemoveRandomListItem();
        } catch (Exception e) {
            Assert.IsTrue(e != null);
        }
    }

    [Test]
    public void shuffleListTest() {
        UnityEngine.Random.seed = 0;
        List<int> list = new List<int>();
        for (int i = 0; i < 10; i++) {
            list.Add(i);
        }
        List<int> expectedResult = new List<int>(new int[] { 6, 8, 0, 7, 4, 2, 5, 3, 1, 9 });

        List<int> output = list.Shuffle();

        for (int i = 0; i < output.Count; i++) {
            Assert.AreEqual(expectedResult[i], output[i]);
        }

    }

    [Test]
    public void shuffleBadListTest() {
        UnityEngine.Random.seed = 0;
        List<int> list = new List<int>();

        try {
            List<int> result = list.Shuffle();
        } catch (Exception e) {
            Assert.IsTrue(e != null);
        }
    }
}