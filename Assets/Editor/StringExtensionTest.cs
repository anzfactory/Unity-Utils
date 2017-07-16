using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Xyz.AnzFactory.Utils.Extension;

public class StringExtensionTest
{

	[Test]
	public void ToColorTest_Success()
    {
        Assert.IsTrue("#FFFFFF".ToColor() == Color.white, "変換失敗！");
        Assert.IsTrue("#FF0000".ToColor() == Color.red, "変換失敗！");
        Assert.IsTrue("#fff".ToColor() == Color.white, "変換失敗！");
        Assert.IsTrue("#FFFFFFFF".ToColor() == Color.white, "変換失敗！");
	}
}
