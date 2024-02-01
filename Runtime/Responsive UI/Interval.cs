using System;
namespace Runtime.UI.Responsive_UI
{
    [Serializable]
    public struct Interval
    {
        public int Min;
        public int Max;
        public static bool IsBetween(int value, Interval interval) => (value <= interval.Max && value >= interval.Min);
    }
}