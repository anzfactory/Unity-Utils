using System;
using System.Linq;
using System.Collections.Generic;

public static class IEnumerableExtension
{
	public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> self)
	{
		return self.OrderBy(i => Guid.NewGuid());
	}
}