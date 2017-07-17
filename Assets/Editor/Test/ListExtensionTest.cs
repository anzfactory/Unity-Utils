using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Xyz.AnzFactory.Utils.Extension;

public class ListExtensionTest
{
	[Test]
	public void AtTest()
	{
		var list = new List<int>();
		list.Add(1);
		list.Add(2);
		list.Add(3);

		var item3 = list.At(2, -1);
		Assert.IsTrue(item3 == 3, "違うアイテムが取得されている！");
	}

	public void AtTest_OutOfRange()
	{
		var list = new List<string>();
		list.Add("item 1");
		list.Add("item 2");
		list.Add("item 3");

		var defaultValue = "item missing";
		var item = list.At(-1, defaultValue);
		Assert.IsTrue(item == defaultValue);
		item = list.At(100, defaultValue);
		Assert.IsTrue(item == defaultValue);
	}

	[Test]
	public void PopTest_Success()
    {
        var list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        var last = list.Pop();
        Assert.IsTrue(last == 3, "最後のアイテムが取れていない！");
        Assert.IsTrue(list.Count == 2, "リストからアイテムが取り出されていない");
	}

    [Test]
    public void PopTest_Failed()
    {
        var list = new List<string>();

        System.Exception ex = null;
        try {
            list.Pop();
        } catch (System.Exception e) {
            ex = e;
        }

        Assert.IsNotNull(ex, "例外が発生していない！");
        Assert.IsInstanceOf<System.InvalidOperationException>(ex, "予期せぬ例外！");
    }

    [Test]
    public void RandomeOneTest_Success_100times()
    {
        var list = new List<string>();
        for (int i = 0; i < 5; i++) {
            list.Add("item " + i.ToString());
        }

        for (int i = 0; i < 100; i++) {
            var one = list.RandomOne();
            Assert.IsTrue(list.Contains(one), "何か変なものを取り出している！");
        }
        Assert.IsTrue(list.Count == 5, "なぜかアイテムが消えている！");
    }

    [Test]
    public void RandomOneTest_Failed()
    {
        var list = new List<string>();

        System.Exception ex = null;
        try {
            list.RandomOne();
        } catch (System.Exception e) {
            ex = e;
        }

        Assert.IsNotNull(ex, "例外が発生していない！");
        Assert.IsInstanceOf<System.InvalidOperationException>(ex, "予期せぬ例外！");
    }
}
