using UnityEngine;

namespace Xyz.AnzFactory.Utils.Localization
{
	[RequireComponent(typeof(UnityEngine.UI.Text))]
	public class TextLocalizer: MonoBehaviour
	{
		#region "SerializeFields"
		[SerializeField] private LocalizationTextData data;
		#endregion
		
		#region "Fields"
		#endregion
		
		#region "Properties"
		#endregion
		
		#region "Lifecycles"
		private void Start()
		{
			var target = gameObject.GetComponent<UnityEngine.UI.Text>();
			target.text = data.GetText(LangSetting.CurrentLang);
		}
		#endregion
		
		#region "Events"
		#endregion
		
		#region "Methods"
		#endregion
		
	}
}