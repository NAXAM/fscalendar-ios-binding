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
    [Register ("FSCalendarConfigViewController")]
    partial class FSCalendarConfigViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker datePicker { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (datePicker != null) {
                datePicker.Dispose ();
                datePicker = null;
            }
        }
    }
}