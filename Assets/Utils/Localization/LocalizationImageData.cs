using UnityEngine;

namespace Xyz.AnzFactory.Utils.Localization
{
	[CreateAssetMenu(menuName="LocalizationImage")]
	public class LocalizationImageData: ScriptableObject
	{
		public System.Collections.Generic.List<LocalizationImageItem> items;

		public Sprite GetSprite(Lang lang)
		{
			for (int i = 0; i < items.Count; i++) {
				var item = items[i];
				if (item.Lang == lang) {
					return item.Sprite;
				}
			}
			
			var filename = "";
			
			#if UNITY_EDITOR
			filename = System.IO.Path.GetFileName(UnityEditor.AssetDatabase.GetAssetPath(this));
			#endif
			
			Debug.LogError($"not found localization data...[{filename}]");
			
			return null;
		}
	}

	[System.Serializable]
	public class LocalizationImageItem
	{
		public Lang Lang;
		public Sprite Sprite;
	}
}