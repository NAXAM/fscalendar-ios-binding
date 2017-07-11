using System;
using ObjCRuntime;
using Foundation;

namespace FSCalendar
{
    [Native]
	public enum FSCalendarCellShape : ulong
	{
	    Circle = 0,
	    Rectangle = 1
	}

	[Native]
	public enum FSCalendarUnit : ulong
	{
	    Month = NSCalendarUnit.Month,
	    WeekOfYear = NSCalendarUnit.WeekOfYear,
	    Day = NSCalendarUnit.Day
	}

	//static class CFunctions
	//{
	//    // void FSCalendarSliceCake (CGFloat cake, NSInteger count, CGFloat *pieces);
	//    [DllImport ("__Internal")]
	//    [Verify (PlatformInvoke)]
	//    static extern unsafe void FSCalendarSliceCake (nfloat cake, long count, nfloat* pieces);
	//}

	[Native]
	public enum FSCalendarCellState : long
	{
	    Normal = 0,
	    Selected = 1,
	    Placeholder = 1 << 1,
	    Disabled = 1 << 2,
	    Today = 1 << 3,
	    Weekend = 1 << 4,
	    TodaySelected = Today | Selected
	}

	[Native]
	public enum FSCalendarSeparators : ulong
	{
	    None = 0,
	    InterRows = 1
	}

	[Native]
	public enum FSCalendarCaseOptions : ulong
	{
	    HeaderUsesDefaultCase = 0,
	    HeaderUsesUpperCase = 1,
	    WeekdayUsesDefaultCase = 0 << 4,
	    WeekdayUsesUpperCase = 1 << 4,
	    WeekdayUsesSingleUpperCase = 2 << 4
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

	[System.Runtime.InteropServices.StructLayout (System.Runtime.InteropServices.LayoutKind.Sequential)]
	public struct FSCalendarCoordinate
	{
	    public long row;

	    public long column;
	}

	[Native]
	public enum FSCalendarTransition : ulong
	{
	    None,
	    MonthToWeek,
	    WeekToMonth
	}

	[Native]
	public enum FSCalendarTransitionState : ulong
	{
	    Idle,
	    Changing,
	    Finishing
	}

}
