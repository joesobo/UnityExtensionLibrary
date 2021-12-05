using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static Extensions.BasicExtensions;

public class BasicTests {
    [UnityTest]
    public IEnumerator cubeVisibleTest() {
        GameObject cameraObj = new GameObject("Camera");
        Camera camera = cameraObj.AddComponent<Camera>();

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(1, 0, 0);
        MeshRenderer renderer = cube.GetComponent<MeshRenderer>();

        Assert.IsTrue(renderer.isVisibleFrom(camera));

        yield return null;
    }

    [UnityTest]
    public IEnumerator cubeNotVisibleTest() {
        GameObject cameraObj = new GameObject("Camera");
        Camera camera = cameraObj.AddComponent<Camera>();

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(-100, 0, 0);
        MeshRenderer renderer = cube.GetComponent<MeshRenderer>();

        Assert.IsFalse(renderer.isVisibleFrom(camera));

        yield return null;
    }

    [UnityTest]
    public IEnumerator destroyChildrenTest() {
        GameObject a = new GameObject();
        GameObject b = new GameObject();
        GameObject c = new GameObject();

        b.transform.parent = a.transform;
        c.transform.parent = a.transform;

        Assert.AreEqual(2, a.transform.childCount);

        a.DestroyChildren();

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(0, a.transform.childCount);
    }

    [UnityTest]
    public IEnumerator getComponentTest() {
        GameObject A = new GameObject();
        A.AddComponent<BoxCollider>();

        Assert.AreEqual(typeof(BoxCollider), A.GetOrAddComponent<BoxCollider>().GetType());

        yield return null;
    }

    [UnityTest]
    public IEnumerator addComponentTest() {
        GameObject A = new GameObject();

        A.GetOrAddComponent<BoxCollider>();

        Assert.IsTrue(A.HasComponent<BoxCollider>());

        yield return null;
    }

    [UnityTest]
    public IEnumerator hasComponentTest() {
        GameObject A = new GameObject();
        A.AddComponent<BoxCollider>();

        Assert.IsTrue(A.HasComponent<BoxCollider>());

        yield return null;
    }

    [UnityTest]
    public IEnumerator setChildLayerTest() {
        GameObject a = new GameObject();
        GameObject b = new GameObject();
        GameObject c = new GameObject();

        b.transform.parent = a.transform;
        c.transform.parent = a.transform;

        a.transform.SetChildLayers("Default");

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(0, b.layer);
        Assert.AreEqual(0, c.layer);
    }

    [UnityTest]
    public IEnumerator setChildLayerRecursiveTest() {
        GameObject a = new GameObject();
        GameObject b = new GameObject();
        GameObject c = new GameObject();

        b.transform.parent = a.transform;
        c.transform.parent = b.transform;

        a.transform.SetChildLayers("Default", true);

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(0, b.layer);
        Assert.AreEqual(0, c.layer);
    }

    [UnityTest]
    public IEnumerator resetChildTransformTest() {
        GameObject a = new GameObject();
        GameObject b = new GameObject();

        b.transform.parent = a.transform;
        b.transform.position = Vector3.one * 5;
        b.transform.rotation = new Quaternion(45, 45, 45, 45);
        b.transform.localScale = Vector3.one * 5;

        a.transform.ResetChildTransform();

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(0, b.transform.position.x, 1);
        Assert.AreEqual(0, b.transform.position.y, 1);
        Assert.AreEqual(0, b.transform.position.z, 1);
        Assert.AreEqual(0, b.transform.rotation.x, 1);
        Assert.AreEqual(0, b.transform.rotation.y, 1);
        Assert.AreEqual(0, b.transform.rotation.z, 1);
        Assert.AreEqual(0, b.transform.rotation.w, 1);
        Assert.AreEqual(1, b.transform.localScale.x, 1);
        Assert.AreEqual(1, b.transform.localScale.y, 1);
        Assert.AreEqual(1, b.transform.localScale.z, 1);
    }

    [UnityTest]
    public IEnumerator resetChildTransformRecursiveTest() {
        GameObject a = new GameObject();
        GameObject b = new GameObject();
        GameObject c = new GameObject();

        b.transform.parent = a.transform;
        b.transform.position = Vector3.one * 5;
        b.transform.rotation = new Quaternion(45, 45, 45, 45);
        b.transform.localScale = Vector3.one * 5;

        c.transform.parent = b.transform;
        c.transform.position = Vector3.one * 5;
        c.transform.rotation = new Quaternion(45, 45, 45, 45);
        c.transform.localScale = Vector3.one * 5;

        a.transform.ResetChildTransform(true);

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(0, b.transform.position.x, 1);
        Assert.AreEqual(0, b.transform.position.y, 1);
        Assert.AreEqual(0, b.transform.position.z, 1);
        Assert.AreEqual(0, b.transform.rotation.x, 1);
        Assert.AreEqual(0, b.transform.rotation.y, 1);
        Assert.AreEqual(0, b.transform.rotation.z, 1);
        Assert.AreEqual(0, b.transform.rotation.w, 1);
        Assert.AreEqual(1, b.transform.localScale.x, 1);
        Assert.AreEqual(1, b.transform.localScale.y, 1);
        Assert.AreEqual(1, b.transform.localScale.z, 1);

        Assert.AreEqual(0, c.transform.position.x, 1);
        Assert.AreEqual(0, c.transform.position.y, 1);
        Assert.AreEqual(0, c.transform.position.z, 1);
        Assert.AreEqual(0, c.transform.rotation.x, 1);
        Assert.AreEqual(0, c.transform.rotation.y, 1);
        Assert.AreEqual(0, c.transform.rotation.z, 1);
        Assert.AreEqual(0, c.transform.rotation.w, 1);
        Assert.AreEqual(1, c.transform.localScale.x, 1);
        Assert.AreEqual(1, c.transform.localScale.y, 1);
        Assert.AreEqual(1, c.transform.localScale.z, 1);
    }

    [UnityTest]
    public IEnumerator resetTransformTest() {
        GameObject a = new GameObject();

        a.transform.position = Vector3.one * 5;
        a.transform.rotation = new Quaternion(45, 45, 45, 45);
        a.transform.localScale = Vector3.one * 5;


        a.transform.ResetTransform();

        yield return new WaitForSeconds(0.1f);

        Assert.AreEqual(0, a.transform.position.x, 1);
        Assert.AreEqual(0, a.transform.position.y, 1);
        Assert.AreEqual(0, a.transform.position.z, 1);
        Assert.AreEqual(0, a.transform.rotation.x, 1);
        Assert.AreEqual(0, a.transform.rotation.y, 1);
        Assert.AreEqual(0, a.transform.rotation.z, 1);
        Assert.AreEqual(0, a.transform.rotation.w, 1);
        Assert.AreEqual(1, a.transform.localScale.x, 1);
        Assert.AreEqual(1, a.transform.localScale.y, 1);
        Assert.AreEqual(1, a.transform.localScale.z, 1);
    }
}
