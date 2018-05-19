namespace Xyz.AnzFactory.Utils.Localization
{
	public enum Lang
	{
		en = 0,
		ja = 10
	}

	public class LangSetting
	{
		private static readonly string PREFS_KEY = "LangSetting.Lang";
		#region "Fields"
		private static LangSetting instance = new LangSetting();
		private Lang currentLang;
		#endregion
		
		#region "Properties"
		public static Lang CurrentLang {
			get { return instance.currentLang; }
			set {
				instance.currentLang = value;
				UnityEngine.PlayerPrefs.SetInt(PREFS_KEY, (int)instance.currentLang);
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