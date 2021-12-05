using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions._3DExtensions;

public class _3DTests {
    [Test]
    public void isInsideRadiusTest() {
        Vector3 input = Vector3.one;
        Vector3 origin = Vector3.zero;

        bool result = input.IsInsideRadius(origin, 2);

        Assert.IsTrue(result);
    }

    [Test]
    public void isInsideRadiusTest2() {
        Vector3 input = Vector3.one * 2;
        Vector3 origin = Vector3.one;

        bool result = input.IsInsideRadius(origin, 2);

        Assert.IsTrue(result);
    }

    [Test]
    public void notInsideRadiusTest() {
        Vector3 input = Vector3.one * 5;
        Vector3 origin = Vector3.zero;

        bool result = input.IsInsideRadius(origin, 2);

        Assert.IsFalse(result);
    }

    [Test]
    public void randomPositionTest() {
        Random.seed = 0;

        Vector3 result = RandomPosition(5);

        Assert.AreEqual(-4.3f, result.x, 1);
        Assert.AreEqual(2.5f, result.y, 1);
        Assert.AreEqual(-0.8f, result.z, 1);
    }

    [Test]
    public void randomPositionBetweenRadiiTest() {
        Random.seed = 0;

        Vector3 result = RandomPositionBetweenRadii(5, 10);

        Assert.AreEqual(-3.2f, result.x, 1);
        Assert.AreEqual(6.2f, result.y, 1);
        Assert.AreEqual(-1.2f, result.z, 1);
    }

    [Test]
    public void setXTest() {
        Vector3 input = Vector3.zero;

        input = input.SetX(1);

        Assert.AreEqual(1, input.x);
        Assert.AreEqual(0, input.y);
        Assert.AreEqual(0, input.z);
    }

    [Test]
    public void setYTest() {
        Vector3 input = Vector3.zero;

        input = input.SetY(1);

        Assert.AreEqual(0, input.x);
        Assert.AreEqual(1, input.y);
        Assert.AreEqual(0, input.z);
    }

    [Test]
    public void setZTest() {
        Vector3 input = Vector3.zero;

        input = input.SetZ(1);

        Assert.AreEqual(0, input.x);
        Assert.AreEqual(0, input.y);
        Assert.AreEqual(1, input.z);
    }

    [Test]
    public void addXTest() {
        Vector3 input = Vector3.one;

        input = input.AddX(1);

        Assert.AreEqual(2, input.x);
        Assert.AreEqual(1, input.y);
        Assert.AreEqual(1, input.z);
    }

    [Test]
    public void addYTest() {
        Vector3 input = Vector3.one;

        input = input.AddY(1);

        Assert.AreEqual(1, input.x);
        Assert.AreEqual(2, input.y);
        Assert.AreEqual(1, input.z);
    }

    [Test]
    public void addZTest() {
        Vector3 input = Vector3.one;

        input = input.AddZ(1);

        Assert.AreEqual(1, input.x);
        Assert.AreEqual(1, input.y);
        Assert.AreEqual(2, input.z);
    }
}