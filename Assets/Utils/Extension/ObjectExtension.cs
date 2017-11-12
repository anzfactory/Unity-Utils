using System;

namespace Xyz.AnzFactory.Utils.Extension
{
	/// <summary>
	/// Objectの拡張
	/// </summary>
	public static class ObjectExtension
	{
		/// <summary>
		/// intにパースする（パースできなかった場合は引数に指定したデフォルトを返す）
		/// </summary>
		/// <returns>The int.</returns>
		/// <param name="self">Self.</param>
		/// <param name="defaultValue">Default value.</param>
		public static int ToInt(this object self, int defaultValue = 0)
		{
			int result;
			if (int.TryParse(self.ToString(), out result)) {
				return result;
			} else if (result != defaultValue) {
				return defaultValue;
			} else {
				return default(int);
			}
		}
	}
}