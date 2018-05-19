using UnityEngine;

namespace Xyz.AnzFactory.Utils.Localization
{
	[RequireComponent(typeof(UnityEngine.UI.Image))]
	public class ImageLocalizer: MonoBehaviour
	{
		#region "SerializeFields"
		[SerializeField] private LocalizationImageData data;
		#endregion
		
		#region "Fields"
		#endregion
		
		#region "Properties"
		#endregion
		
		#region "Lifecycles"
		private void Start()
		{
			var target = gameObject.GetComponent<UnityEngine.UI.Image>();
			target.sprite = data.GetSprite(LangSetting.CurrentLang);
		}
		#endregion
		
		#region "Events"
		#endregion
		
		#region "Methods"
		#endregion
		
	}
}