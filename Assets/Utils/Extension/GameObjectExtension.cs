using System;
using System.Collections.Generic;
using UnityEngine;

namespace Xyz.AnzFactory.Utils.Extension
{
    public static class GameObjectExtension
    {
        public static T AddComponentIfNeeded<T>(this GameObject self) where T:Component
        {
            T additionalComponent = self.GetComponent<T>();
            if (additionalComponent == null) {
                additionalComponent = self.AddComponent<T>();
            }
            return additionalComponent;
        }
    }
}
