using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace FSCalendarAbstractions
{
    [Native]
    public enum FSCalendarCellState : long
    {
        Normal = 0,
        Selected = 1,
        Placeholder = 1L << 1,
        Disabled = 1L << 2,
        Today = 1L << 3,
        Weekend = 1L << 4,
        TodaySelected = Today | Selected
    }

    [Native]
    public enum FSCalendarSeparators : ulong
    {
        None = 0,
        InterRows = 1
    }

    [Flags]
    [Native]
    public enum FSCalendarCaseOptions : ulong
    {
        HeaderUsesDefaultCase = 0x0,
        HeaderUsesUpperCase = 1uL << 0,
        HeaderUsesCapitalized = 1uL << 1,
        WeekdayUsesDefaultCase = 0uL << 4,
        WeekdayUsesUpperCase = 1uL << 4,
        WeekdayUsesSingleUpperCase = 2uL << 4
    }

    [Native]
    public enum FSCalendarScope : ulong
    {
        Month,
        Week
    }

    [Native]
    public enum FSCalendarScrollDirection : ulong
    {
        Vertical,
        Horizontal
    }

    [Native]
    public enum FSCalendarPlaceholderType : ulong
    {
        None = 0,
        FillHeadTail = 1,
        FillSixRows = 2
    }

    [Native]
    public enum FSCalendarMonthPosition : ulong
    {
        Previous,
        Current,
        Next,
        NotFound = ulong.MaxValue
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FSCalendarCoordinate
    {
        public nint row;

        public nint column;
    }

    [Native]
    public enum FSCalendarTransitionState : ulong
    {
        Idle,
        Changing,
        Finishing
    }
}
