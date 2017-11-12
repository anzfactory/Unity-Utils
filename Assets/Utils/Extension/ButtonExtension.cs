using UnityEngine.UI;

namespace Xyz.AnzFactory.Utils.Extension
{
	/// <summary>
	/// uGUI.Buttonの拡張
	/// </summary>
	public static class ButtonExtension
	{
		/// <summary>
		/// Textコンポーネントを探して指定された文字列をセットする
		/// </summary>
		/// <param name="self">Self.</param>
		/// <param name="title">Title.</param>
		public static void SetTitle(this Button self, string title)
		{
			var text = self.GetComponentInChildren<Text>();
			if (text == null) {
				UnityEngine.Debug.LogWarning("Not found text compoent");
				return;
			}
			text.text = title;
		}
	}
}