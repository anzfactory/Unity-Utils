using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Xyz.AnzFactory.Utils.Extension
{
	/// <summary>
	/// GameObjectの拡張クラス
	/// </summary>
    public static class GameObjectExtension
    {
		/// <summary>
		/// <para>必要であれば指定されたコンポーネントを追加する</para>
		/// <para>指定されたコンポーネントがすでにあるのなら追加はしないし
		/// なければ追加するいたいな</para>
		/// </summary>
		/// <returns>追加した（あついは既存の場合は取得した）コンポーネント</returns>
		/// <param name="self">Self.</param>
		/// <typeparam name="T">Component</typeparam>
        public static T AddComponentIfNeeded<T>(this GameObject self) where T:Component
        {
			return self.GetComponent<T>() ?? self.AddComponent<T>();
        }

		/// <summary>
		/// EventTriggerType.PointerClickを追加設定する
		/// </summary>
		/// <param name="self">Self.</param>
		/// <param name="callback">Callback.</param>
		public static void AddClickEventTrigger(this GameObject self, UnityAction<BaseEventData> callback)
		{
			self.AddEventTrigger(EventTriggerType.PointerClick, callback);
		}

		/// <summary>
		/// EventTriggerを追加設定する
		/// </summary>
		/// <param name="self">Self.</param>
		/// <param name="triggerType">Trigger type.</param>
		/// <param name="callback">Callback.</param>
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
