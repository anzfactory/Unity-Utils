using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Xyz.AnzFactory.Utils.Extension
{
	/// <summary>
	/// String拡張クラス
	/// </summary>
	public static class StringExtension
	{
		/// <summary>
		/// カラーコードからColorを作り出す
		/// </summary>
		/// <returns>Color</returns>
		/// <param name="self">Self.</param>
	    public static Color ToColor(this string self)
	    {
	        var color = default(Color);
	        if (!ColorUtility.TryParseHtmlString(self, out color)) {
	            Debug.LogWarning("Unknown color code... " + self);
	        }

	        return color;
	    }
	}
}
