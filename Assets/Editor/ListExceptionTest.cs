using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Xyz.AnzFactory.Utils.Extension;

public class ListExceptionTest
{

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
}
