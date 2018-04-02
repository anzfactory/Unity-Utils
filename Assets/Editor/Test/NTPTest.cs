using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Xyz.AnzFactory.Utils.Network;

public class NTPTest
{

	[Test]
	public void GetTimestampTest_long()
    {
		var gameObject = new GameObject("NTP");
		var ntp = gameObject.AddComponent<NTP>();
		ntp.GetTimestamp((long? timestamp) => {
			Debug.Log(timestamp);
			Assert.IsNotNull(timestamp);
		});
	}

	[Test]
	public void GetTimestampTest_DateTime()
    {
		var gameObject = new GameObject("NTP");
		var ntp = gameObject.AddComponent<NTP>();
		ntp.GetTimestamp((System.DateTime? timestamp) => {
			Debug.Log(timestamp);
			Assert.IsNotNull(timestamp);
		});
	}
}