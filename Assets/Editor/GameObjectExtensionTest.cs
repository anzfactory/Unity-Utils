using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Xyz.AnzFactory.Utils;

public class GameObjectExtensionTest
{

	[Test]
	public void AddComponentIfNeeded_NotYet()
    {
        var gameObject = new GameObject("Test");
        var text = gameObject.AddComponentIfNeeded<Text>();

        Assert.IsTrue(text is Text, "追加されたコンポーネントがちがう！");
        Assert.IsTrue(gameObject.GetComponents<Text>().Length == 1, "余計にコンポーネントがアタッチされている！");
	}

    [Test]
    public void AddComponentIfNeeded_AlreadyExists()
    {
        var gameObject = new GameObject("Test");
        var original = gameObject.AddComponent<Button>();
        var additional = gameObject.AddComponentIfNeeded<Button>();

        Assert.IsTrue(original == additional, "既にあったのにはりつけてしまっている！");
        Assert.IsTrue(gameObject.GetComponents<Button>().Length == 1, "余計にコンポーネントがアタッチされている！");
    }

}
