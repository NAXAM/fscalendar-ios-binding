// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FSCalendarQS
{
    [Register ("FSStoryboardExampleViewController")]
    partial class FSStoryboardExampleViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        FSCalendarAbstractions.FSCalendar calendar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint calendarHeightConstraint { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (calendar != null) {
                calendar.Dispose ();
                calendar = null;
            }

            if (calendarHeightConstraint != null) {
                calendarHeightConstraint.Dispose ();
                calendarHeightConstraint = null;
            }
        }
    }
}