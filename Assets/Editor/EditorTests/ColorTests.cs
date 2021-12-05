using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.ColorExtensions;

public class ColorTests {
    [Test]
    public void hexToRgbaTest() {
        string hex = "#000000";

        Color32 color = hex.HexToRGBA32();

        Assert.AreEqual(0, color.r);
        Assert.AreEqual(0, color.g);
        Assert.AreEqual(0, color.b);
        Assert.AreEqual(255, color.a);
    }

    [Test]
    public void hexToRgbaTest2() {
        string hex = "0x000000";

        Color32 color = hex.HexToRGBA32();

        Assert.AreEqual(0, color.r);
        Assert.AreEqual(0, color.g);
        Assert.AreEqual(0, color.b);
        Assert.AreEqual(255, color.a);
    }

    [Test]
    public void hexToRgbaTest3() {
        string hex = "#000000";

        Color32 color = hex.HexToRGBA32(0);

        Assert.AreEqual(0, color.r);
        Assert.AreEqual(0, color.g);
        Assert.AreEqual(0, color.b);
        Assert.AreEqual(0, color.a);
    }

    [Test]
    public void hexToRgbaTest4() {
        string hex = "#00000000";

        Color32 color = hex.HexToRGBA32();

        Assert.AreEqual(0, color.r);
        Assert.AreEqual(0, color.g);
        Assert.AreEqual(0, color.b);
        Assert.AreEqual(0, color.a);
    }

    [Test]
    public void rgbToHexTest() {
        Color32 color = Color.red;

        string hex = color.RGBToHex32();

        Assert.AreEqual("#FF0000FF", hex);
    }

    [Test]
    public void withHalfAlphaTest() {
        Color32 color = Color.red;

        color = color.WithAlpha32(125);

        Assert.AreEqual(125, color.a);
    }

    [Test]
    public void withZeroAlphaTest() {
        Color32 color = Color.red;

        color = color.WithAlpha32(0);

        Assert.AreEqual(0, color.a);
    }
}