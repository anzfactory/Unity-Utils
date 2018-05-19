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
		private void Awake()
		{
			LangSetting.Instance.OnChangedCurrentLang += OnChangedCurrentLang;
		}

		private void Start()
		{
			UpdateText();
		}

		private void OnDestroy()
		{
			LangSetting.Instance.OnChangedCurrentLang -= OnChangedCurrentLang;
		}
		#endregion
		
		#region "Events"
		private void OnChangedCurrentLang()
		{
			UpdateText();
		}
		#endregion
		
		#region "Methods"
		private void UpdateText()
		{
			var target = gameObject.GetComponent<UnityEngine.UI.Text>();
			target.text = data.GetText(LangSetting.Instance.CurrentLang);
		}
		#endregion
		
	}
}