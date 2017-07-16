using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Xyz.AnzFactory.Utils.Extension
{
    public static class GameObjectExtension
    {
        public static T AddComponentIfNeeded<T>(this GameObject self) where T:Component
        {
			return self.GetComponent<T>() ?? self.AddComponent<T>();
        }

		public static void AddClickEventTrigger(this GameObject self, UnityAction<BaseEventData> callback)
		{
			self.AddEventTrigger(EventTriggerType.PointerClick, callback);
		}

		public static void AddEventTrigger(this GameObject self, EventTriggerType triggerType, UnityAction<BaseEventData> callback)
		{
			var entry = new EventTrigger.Entry();
			entry.eventID = triggerType;
			entry.callback.AddListener(callback);

			var trigger = self.AddComponentIfNeeded<EventTrigger>();
			trigger.triggers.Add(entry);
		}
    }
}
