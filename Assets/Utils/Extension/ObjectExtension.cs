using System;

public static class ObjectExtension
{
	public static int ToInt(this object self, int defaultValue = 0)
	{
		int result;
		if (int.TryParse(self.ToString(), out result)) {
			return result;
		} else if (result != defaultValue) {
			return defaultValue;
		} else {
			return default(int);
		}
	}
}