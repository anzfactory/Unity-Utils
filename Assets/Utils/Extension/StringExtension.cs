using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringExtension
{
    public static Color ToColor(this string self)
    {
        var color = default(Color);
        if (!ColorUtility.TryParseHtmlString(self, out color)) {
            Debug.LogWarning("Unknown color code... " + self);
        }
        return color;
    }
}
