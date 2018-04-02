using System;

namespace Xyz.AnzFactory.Utils.Extension
{
	/// <summary>
	/// DateTime拡張クラス
	/// </summary>
    public static class DateTimeExtension
    {
		public static long Timestamp(this DateTime self)
		{
			var span = TimeZoneInfo.ConvertTimeToUtc(self) - new DateTime(year: 1970, month: 1, day: 1, hour: 0, minute: 0, second: 0, kind: DateTimeKind.Utc);
			return (long)span.TotalSeconds;
		}
    }
}