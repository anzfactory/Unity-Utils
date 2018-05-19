using UnityEngine;
using Xyz.AnzFactory.Utils.Localization;

namespace Xyz.Sample.Localization
{
	public class Toggle: MonoBehaviour
	{
		#region "SerializeFields"
		#endregion
		
		#region "Fields"
		#endregion
		
		#region "Properties"
		#endregion
		
		#region "Lifecycles"
		private void Awake()
		{
		}
		
		private void Start()
		{
		}
		#endregion
		
		#region "Events"
		public void OnToggle()
		{
			if (LangSetting.Instance.CurrentLang == Lang.en) {
				LangSetting.Instance.CurrentLang = Lang.ja;
			} else {
				LangSetting.Instance.CurrentLang = Lang.en;
			}
		}
		#endregion
		
		#region "Methods"
		#endregion
		
	}
}