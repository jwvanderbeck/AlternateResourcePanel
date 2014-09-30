﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using KSP;
using UnityEngine;

namespace KSPPluginFramework
{
    /// <summary>
    /// CLass containing some extension methods for Unity Objects
    /// </summary>
    public static class UnityExtensions
    {
        /// <summary>
        /// Ensure that the Rect remains within the screen bounds
        /// </summary>
        public static Rect ClampToScreen(this Rect r)
        {
            return r.ClampToScreen(new RectOffset(0, 0, 0, 0));
        }

        /// <summary>
        /// Ensure that the Rect remains within the screen bounds
        /// </summary>
        /// <param name="ScreenBorder">A Border to the screen bounds that the Rect will be clamped inside (can be negative)</param>
        public static Rect ClampToScreen(this Rect r, RectOffset ScreenBorder)
        {
            r.x = Mathf.Clamp(r.x, ScreenBorder.left, Screen.width - r.width - ScreenBorder.right);
            r.y = Mathf.Clamp(r.y, ScreenBorder.top, Screen.height - r.height - ScreenBorder.bottom);
            return r;
        }
    }
}