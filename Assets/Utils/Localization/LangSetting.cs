
namespace Xyz.AnzFactory.Utils.Localization
{
	public enum Lang
	{
		en = 0,
		ja = 10
	}

	public class LangSetting
	{
		private static readonly string PREFS_KEY = "Xyz.AnzFactory.Util.Localization.LangSetting.Lang";
		
		#region "Fields"
		public System.Action OnChangedCurrentLang;
		private static LangSetting instance = new LangSetting();
		private Lang currentLang;
		
		#endregion
		
		#region "Properties"
		public static LangSetting Instance
		{
			get { return instance; }
		}
		public Lang CurrentLang
		{
			get { return instance.currentLang; }
			set {
				if (instance.currentLang == value) {
					return;
				}
				instance.currentLang = value;
				OnChangedCurrentLang?.Invoke();	// 変更通知
				UnityEngine.PlayerPrefs.SetInt(PREFS_KEY, (int)instance.currentLang);
				UnityEngine.PlayerPrefs.Save();
			}
		}
		#endregion
		
		#region "Constructor"
		private LangSetting()
		{
			var langValue = UnityEngine.PlayerPrefs.GetInt(PREFS_KEY, (int)Lang.en);
			currentLang = (Lang)System.Enum.ToObject(typeof(Lang), langValue);
		}
		#endregion
		
		#region "Methods"
		#endregion
		
	}
}