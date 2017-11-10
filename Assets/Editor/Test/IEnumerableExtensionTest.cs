using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Xyz.AnzFactory.Utils.Extension;

public class IEnumerableExtensionTest
{
	[Test]
	public void ShuffleTest()
	{
		var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		var result = numbers.Shuffle().ToArray();

		Assert.IsTrue(numbers.Length == result.Length, "要素数が変わってしまっている");
		Assert.IsTrue(numbers.Length == result.Distinct().Count(), "重複した要素ができてしまっている");
		foreach (int num in numbers) {
			Assert.IsTrue(result.Contains(num), "内容が変わってしまっている:{0}", num);
		}

		// ばらつきを雑に検証する
		var firstNumbers = new List<int>();
		for (int i = 0; i < 10; i++) {
			var shuffle = numbers.Shuffle().ToArray();
			firstNumbers.Add(shuffle[0]);
		}

		Assert.IsTrue(firstNumbers.Distinct().Count() > 5, "ばらつきにかたよりあるかも？\n{0}", string.Join(",", firstNumbers.Select(i => i.ToString()).ToArray()));
	}
}
