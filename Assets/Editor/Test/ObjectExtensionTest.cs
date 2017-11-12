using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Xyz.AnzFactory.Utils.Extension;

public class ObjectExtensionTest
{
	[Test]
	public void ToIntTest()
	{
		var result = "5".ToInt();
		Assert.IsTrue(result == 5);
	}

	[Test]
	public void ToIntTest_Failed()
	{
		var result = "".ToInt();
		Assert.IsTrue(result == 0);
		result = "abc".ToInt();
		Assert.IsTrue(result == 0);
	}

	[Test]
	public void ToIntTest_Default()
	{
		var result = "abc".ToInt(5);
		Assert.IsTrue(result == 5);
		result = "20".ToInt(5);
		Assert.IsTrue(result == 20);
	}

}
