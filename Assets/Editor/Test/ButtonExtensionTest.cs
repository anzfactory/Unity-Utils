using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using Xyz.AnzFactory.Utils.Extension;

public class ButtonExtensionTest
{

	[Test]
	public void SetTitle()
	{
		var title = "ぼたんたいとる";
		var go = this.CreateButtonObject();
		var button = go.GetComponent<Button>();
		button.SetTitle(title);

		Assert.IsTrue(title == go.GetComponentInChildren<Text>().text, "タイトルちがう...");
	}


	private GameObject CreateButtonObject()
	{
		// ヒエラルキーから作ったような階層を想定している
		var go = new GameObject();
		go.AddComponent<Button>();
		var textGo = new GameObject();
		textGo.AddComponent<Text>();
		textGo.transform.SetParent(go.transform, false);
		return go;
	}
}
