using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.StringExtensions;

public class StringTests {
    [Test]
    public void truncateTest() {
        string input = "Hello";

        input = input.Truncate(4);

        Assert.AreEqual("Hell", input);
    }

    [Test]
    public void truncateTest2() {
        string input = "";

        input = input.Truncate(4);

        Assert.AreEqual("", input);
    }

    [Test]
    public void truncateTest3() {
        string input = "Hello";

        input = input.Truncate(40);

        Assert.AreEqual("Hello", input);
    }

    [Test]
    public void truncateTest4() {
        string input = "Hello";

        input = input.Truncate(1, 4);

        Assert.AreEqual("ell", input);
    }

    [Test]
    public void truncateTest5() {
        string input = "Hello";

        input = input.Truncate(1, 40);

        Assert.AreEqual("Hello", input);
    }

    [Test]
    public void withTest() {
        string input = "Hello {0}";

        input = input.With("Joe");

        Assert.AreEqual("Hello Joe", input);
    }
}