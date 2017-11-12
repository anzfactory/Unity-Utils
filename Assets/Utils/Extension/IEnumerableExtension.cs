using System;
using System.Linq;
using System.Collections.Generic;

namespace Xyz.AnzFactory.Utils.Extension
{
	/// <summary>
	/// IEnumerable拡張クラス
	/// </summary>
	public static class IEnumerableExtension
	{
		/// <summary>
		/// シャッフルして返す
		/// </summary>
		/// <param name="self">Self.</param>
		/// <typeparam name="T">IEnumerable</typeparam>
		public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> self)
		{
			return self.OrderBy(i => Guid.NewGuid());
		}
	}
}