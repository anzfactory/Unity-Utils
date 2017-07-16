using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Xyz.AnzFactory.Utils.Extension
{
	public static class TransformExtension
	{
		/// <summary>
		/// 再帰的にLayerを変える
		/// </summary>
		public static void ChangeLayersRecursively(this Transform self, string name)
		{
			self.gameObject.layer = LayerMask.NameToLayer(name);
			foreach(Transform child in self) {
				child.ChangeLayersRecursively(name);
			}
		}
	}
}
