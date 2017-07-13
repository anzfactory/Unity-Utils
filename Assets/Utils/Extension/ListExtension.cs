using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Xyz.AnzFactory.Utils.Extension
{
    public static class ListExtension
    {
        public static T Pop<T>(this List<T> self)
        {
            if (self.Count == 0) {
                throw new System.InvalidOperationException("件数が0件");
            }

            var item = self[self.Count - 1];
            self.RemoveAt(self.Count - 1);
            return item;
        }
    }
}