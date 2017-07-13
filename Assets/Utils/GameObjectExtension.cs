using System.Collections.Generic;
using UnityEngine;

namespace Xyz.AnzFactory.Utils
{
    public static class GameObjectExtension
    {
        public static T AddComponentIfNeeded<T>(this GameObject gameObject) where T:Component
        {
            T additionalComponent = gameObject.GetComponent<T>();
            if (additionalComponent == null) {
                    additionalComponent = gameObject.AddComponent<T>();
            }
            return additionalComponent;
        }
    }
}
