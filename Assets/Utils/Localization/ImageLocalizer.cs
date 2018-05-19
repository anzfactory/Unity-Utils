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
		private void Awake()
		{
			LangSetting.Instance.OnChangedCurrentLang += OnChangedCurrentLang;
		}

		private void Start()
		{
			UpdateImage();
		}

		private void OnDestroy()
		{
			LangSetting.Instance.OnChangedCurrentLang -= OnChangedCurrentLang;
		}
		#endregion
		
		#region "Events"
		private void OnChangedCurrentLang()
		{
			UpdateImage();
		}
		#endregion
		
		#region "Methods"
		private void UpdateImage()
		{
			var target = gameObject.GetComponent<UnityEngine.UI.Image>();
			target.sprite = data.GetSprite(LangSetting.Instance.CurrentLang);
		}
		#endregion
		
	}
}