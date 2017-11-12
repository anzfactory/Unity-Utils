using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Xyz.AnzFactory.Utils.Extension
{
	/// <summary>
	/// List拡張クラス
	/// </summary>
    public static class ListExtension
    {
		/// <summary>
		/// 指定されたindexを取得する。領域外だった場合には指定されているDefaultを返す
		/// </summary>
		/// <param name="self">Self.</param>
		/// <param name="index">取得したいIndex</param>
		/// <param name="defaultValue">指定したIndexが領域外の場合のDefault value.</param>
		public static T At<T>(this List<T> self, int index, T defaultValue)
		{
			if (0 > index || index >= self.Count) {
				return defaultValue;
			}
			return self[index];
		}

		/// <summary>
		/// リストの最後尾を抜き出す（破壊的）
		/// </summary>
		/// <param name="self">Self.</param>
        public static T Pop<T>(this List<T> self)
        {
            if (self.Count == 0) {
                throw new System.InvalidOperationException("件数が0件");
            }

            var item = self[self.Count - 1];
            self.RemoveAt(self.Count - 1);
            return item;
        }

		/// <summary>
		/// リストからランダムで1つ取得する
		/// </summary>
		/// <returns>The one.</returns>
		/// <param name="self">Self.</param>
        public static T RandomOne<T>(this List<T> self)
        {
            if (self.Count == 0) {
                throw new System.InvalidOperationException("件数が0件");
            }

            return self[UnityEngine.Random.Range(0, self.Count)];
        }
    }
}