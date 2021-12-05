using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.ColorExtensions;

public class ColorTest {
    [Test]
    public void hex_to_rgba_test() {
        //Arrange
        string hex = "#000000";

        //Act
        Color32 color = hex.HexToRGBA32();

        //Assert
        Assert.AreEqual(0, color.r);
        Assert.AreEqual(0, color.g);
        Assert.AreEqual(0, color.b);
        Assert.AreEqual(255, color.a);
    }

    [Test]
    public void hex_to_rgba_test2() {
        //Arrange
        string hex = "0x000000";

        //Act
        Color32 color = hex.HexToRGBA32();

        //Assert
        Assert.AreEqual(0, color.r);
        Assert.AreEqual(0, color.g);
        Assert.AreEqual(0, color.b);
        Assert.AreEqual(255, color.a);
    }

    [Test]
    public void hex_to_rgba_test3() {
        //Arrange
        string hex = "#000000";

        //Act
        Color32 color = hex.HexToRGBA32(0);

        //Assert
        Assert.AreEqual(0, color.r);
        Assert.AreEqual(0, color.g);
        Assert.AreEqual(0, color.b);
        Assert.AreEqual(0, color.a);
    }

    [Test]
    public void hex_to_rgba_test4() {
        //Arrange
        string hex = "#00000000";

        //Act
        Color32 color = hex.HexToRGBA32();

        //Assert
        Assert.AreEqual(0, color.r);
        Assert.AreEqual(0, color.g);
        Assert.AreEqual(0, color.b);
        Assert.AreEqual(0, color.a);
    }

    [Test]
    public void rgb_to_hex_test() {
        //Arrange
        Color32 color = Color.red;

        //Act
        string hex = color.RGBToHex32();

        //Assert
        Assert.AreEqual("#FF0000FF", hex);
    }

    [Test]
    public void with_half_alpha_test() {
        //Arrange
        Color32 color = Color.red;

        //Act
        color = color.WithAlpha32(125);

        //Assert
        Assert.AreEqual(125, color.a);
    }

    [Test]
    public void with_zero_alpha_test() {
        //Arrange
        Color32 color = Color.red;

        //Act
        color = color.WithAlpha32(0);

        //Assert
        Assert.AreEqual(0, color.a);
    }
}