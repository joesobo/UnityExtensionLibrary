using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions._2DExtensions;

public class _2DTests {
    [Test]
    public void rotate90Test() {
        Vector2 v = new Vector2(1, 0);

        Vector2 result = v.Rotate(90);

        Assert.AreEqual(0, result.x, 1);
        Assert.AreEqual(1, result.y, 1);
    }

    [Test]
    public void rotate45Test() {
        Vector2 v = new Vector2(1, 0);

        Vector2 result = v.Rotate(45);

        Assert.AreEqual(0.7f, result.x, 1);
        Assert.AreEqual(0.7f, result.y, 1);
    }

    [Test]
    public void rotationNormalizedDegreeTest() {
        float inputDegrees = 726;

        float result = inputDegrees.RotationNormalizedDegree();

        Assert.AreEqual(6, result);
    }

    [Test]
    public void rotationNormalizedDegree_360Test() {
        float inputDegrees = 360;

        inputDegrees.RotationNormalizedDegree();

        Assert.AreEqual(360, inputDegrees);
    }

    [Test]
    public void rotationNormalizedDegree_0Test() {
        float inputDegrees = 0;

        inputDegrees.RotationNormalizedDegree();

        Assert.AreEqual(0, inputDegrees);
    }

    [Test]
    public void convertVector3Test() {
        Vector2 input = Vector2.one;

        Vector3 output = input.ConvertToVector3(1);

        Assert.AreEqual(output.x, 0, 1);
        Assert.AreEqual(output.y, 0, 1);
        Assert.AreEqual(output.z, 1, 1);
    }

    [Test]
    public void setXTest() {
        Vector2 input = Vector2.zero;

        input = input.SetX(1);

        Assert.AreEqual(1, input.x);
        Assert.AreEqual(0, input.y);
    }

    [Test]
    public void setYTest() {
        Vector2 input = Vector2.zero;

        input = input.SetY(1);

        Assert.AreEqual(0, input.x);
        Assert.AreEqual(1, input.y);
    }

    [Test]
    public void addXTest() {
        Vector2 input = Vector2.one;

        input = input.AddX(1);

        Assert.AreEqual(2, input.x);
        Assert.AreEqual(1, input.y);
    }

    [Test]
    public void addYTest() {
        Vector2 input = Vector2.one;

        input = input.AddY(1);

        Assert.AreEqual(1, input.x);
        Assert.AreEqual(2, input.y);
    }
}