using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.NumericalExtensions;

public class NumberTests {
    [Test]
    public void linearRemapTest() {
        float input = 0.5f;

        float result = input.LinearRemap(0, 1, 0, 100);

        Assert.AreEqual(50, result);
    }

    [Test]
    public void linearRemapTest2() {
        float input = 1.5f;

        float result = input.LinearRemap(0, 1, 0, 100);

        Assert.AreEqual(150, result);
    }

    [Test]
    public void randomSignPositiveTest() {
        Random.seed = 0;
        int input = 1;

        int result = input.WithRandomSign();

        Assert.AreEqual(1, 1);
    }

    [Test]
    public void randomSignNegativeTest() {
        Random.seed = 1;
        int input = 1;

        int result = input.WithRandomSign();

        Assert.AreEqual(1, 1);
    }

    [Test]
    public void randomSignZeroChanceTest() {
        Random.seed = 0;
        int input = 1;

        int result = input.WithRandomSign(0);

        Assert.AreEqual(1, 1);
    }

    [Test]
    public void random50PercentProbabilityTest() {
        Random.seed = 0;
        int chance = 50;

        Assert.IsTrue(RandomProbability(chance));
    }

    [Test]
    public void random50PercentProbabilityTest2() {
        Random.seed = 1;
        int chance = 50;

        Assert.IsFalse(RandomProbability(chance));
    }

    [Test]
    public void random100PercentProbabilityTest() {
        int chance = 100;

        Assert.IsTrue(RandomProbability(chance));
    }

    [Test]
    public void random0PercentProbabilityTest() {
        int chance = 0;

        Assert.IsFalse(RandomProbability(chance));
    }

    [Test]
    public void squaredIntTest() {
        int input = 2;

        Assert.AreEqual(4, input.Squared());
    }

    [Test]
    public void squaredFloatTest() {
        float input = 2.5f;

        Assert.AreEqual(6.25f, input.Squared(), 1);
    }

    [Test]
    public void cubedIntTest() {
        int input = 2;

        Assert.AreEqual(8, input.Cubed());
    }

    [Test]
    public void cubedFloatTest() {
        float input = 2.5f;

        Assert.AreEqual(15.625f, input.Cubed(), 1);
    }

    [Test]
    public void divideIntTest() {
        int denominator = 3;
        int numerator = 10;

        Divide(numerator, denominator, out int result, out int remainder);

        Assert.AreEqual(3, result);
        Assert.AreEqual(1, remainder);
    }

    [Test]
    public void divideFloatTest() {
        float denominator = 3.5f;
        float numerator = 12.5f;

        Divide(numerator, denominator, out float result, out float remainder);

        Assert.AreEqual(3.57142854f, result);
        Assert.AreEqual(2, remainder);
    }

    [Test]
    public void isBetweenTest() {
        Assert.IsTrue(5f.IsBetween(0f, 10f));
        Assert.IsFalse(15f.IsBetween(0f, 10f));
        Assert.IsTrue((-5f).IsBetween(-0f, -10f));
    }

    [Test]
    public void swapIntTest() {
        int x = 1;
        int y = 2;

        Swap(ref x, ref y);

        Assert.AreEqual(1, y);
        Assert.AreEqual(2, x);
    }

    [Test]
    public void swapFloatTest() {
        float x = 1.5f;
        float y = 2.5f;

        Swap(ref x, ref y);

        Assert.AreEqual(1.5f, y);
        Assert.AreEqual(2.5f, x);
    }
}