using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.BasicExtensions;

public class BasicTests {
    [Test]
    public void getDirectionTest() {
        Vector3 start = Vector3.zero;
        Vector3 end = new Vector3(1, 0, 0);

        Vector3 output = GetDirection(start, end);

        Assert.AreEqual(1, output.x, 1);
        Assert.AreEqual(0, output.y, 1);
        Assert.AreEqual(0, output.z, 1);
    }

    [Test]
    public void getDirectionTest2() {
        Vector3 start = new Vector3(1, 0, 1);
        Vector3 end = new Vector3(5, 0, 5);

        Vector3 output = GetDirection(start, end);

        Assert.AreEqual(0.7f, output.x, 5);
        Assert.AreEqual(0, output.y, 5);
        Assert.AreEqual(0.7f, output.z, 5);
    }
}