using Nova;
using System;
using UnityEngine;
using UnityEngine.Serialization;
namespace Runtime.UI.Responsive_UI
{
    /// <summary>
    /// Breakpoint wrapper class.
    /// If screen resolution is found within this breakpoints bound, will update all ui elements that contain the same breakpoint name.
    /// </summary>
    [Serializable]
    public class Breakpoints
    {
        public string BreakpointName;
        public Interval BreakpointWidth;
        public Interval BreakpointLength;
        public UIBlock2D UIRoot;
        public static bool IsBreakpointChange(Vector2 resolution, Breakpoints breakpoint) => Interval.IsBetween((int)resolution.x, breakpoint.BreakpointWidth) || Interval.IsBetween((int)resolution.y, breakpoint.BreakpointLength);
    }
}