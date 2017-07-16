using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Xyz.AnzFactory.Utils.Extension
{
    public static class GameObjectExtension
    {
        public static T AddComponentIfNeeded<T>(this GameObject self) where T:Component
        {
			return self.GetComponent<T>() ?? self.AddComponent<T>();
        }
    }
}
