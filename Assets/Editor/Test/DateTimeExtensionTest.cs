using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using Xyz.AnzFactory.Utils.Extension;

public class DateTimeExtensionTest
{
	[Test]
	public void TimestampTest()
	{
		var date = new System.DateTime(2018, 4, 2, 23, 35, 16);
		var timestamp = date.Timestamp();
		
		// https://ntp-a1.nict.go.jp/cgi-bin/json より 2018/04/02 23:36:16 は 1522679716.421
		Assert.IsTrue(timestamp == 1522679716L);
	}

	[Test]
	public void TimestampTest_Minus()
	{
		var date = new System.DateTime(1968, 2, 1, 20, 11, 32);
		var timestamp = date.Timestamp();
		Assert.IsTrue(0 > timestamp);
	}
}