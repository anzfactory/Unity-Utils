using UnityEngine;

namespace Xyz.AnzFactory.Utils.Localization
{
	[CreateAssetMenu(menuName="LocalizationText")]
	public class LocalizationTextData: ScriptableObject
	{
		public System.Collections.Generic.List<LocalizationTextItem> items;

		public string GetText(Lang lang)
		{
			for (int i = 0; i < items.Count; i++) {
				var item = items[i];
				if (item.Lang == lang) {
					return item.Text;
				}
			}
			
			var filename = "";
			
			#if UNITY_EDITOR
			filename = System.IO.Path.GetFileName(UnityEditor.AssetDatabase.GetAssetPath(this));
			#endif
			
			Debug.LogError($"not found localization data...[{filename}]");
			
			return "";
		}
	}

	[System.Serializable]
	public class LocalizationTextItem
	{
		public Lang Lang;
		public string Text;
	}
}