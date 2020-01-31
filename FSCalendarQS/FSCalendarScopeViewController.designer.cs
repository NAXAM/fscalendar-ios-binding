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
    [Register ("FSCalendarScopeViewController")]
    partial class FSCalendarScopeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch animationSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        FSCalendarAbstractions.FSCalendar calendar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint calendarHeightConstraint { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView tableView { get; set; }

        [Action ("toggleClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void toggleClicked (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (animationSwitch != null) {
                animationSwitch.Dispose ();
                animationSwitch = null;
            }

            if (calendar != null) {
                calendar.Dispose ();
                calendar = null;
            }

            if (calendarHeightConstraint != null) {
                calendarHeightConstraint.Dispose ();
                calendarHeightConstraint = null;
            }

            if (tableView != null) {
                tableView.Dispose ();
                tableView = null;
            }
        }
    }
}