﻿using System;
using Foundation;
using UIKit;
using CoreGraphics;
using FSCalendarAbstractions;

namespace FSCalendarQS.RangePicker
{
    public class RangePickerViewController : UIViewController, IFSCalendarDelegate, IFSCalendarDataSource
    {
        public RangePickerViewController(IntPtr handle) : base(handle)
        {
        }

        public RangePickerViewController() : base()
        {
            Title = "Range picker";
        }

        FSCalendar Calendar;
        NSCalendar Gregorian;
        NSDateFormatter DateFormatter;
        NSDate Date1;
        NSDate Date2;

        public override void LoadView()
        {
            base.LoadView();
            View = new UIView(UIScreen.MainScreen.Bounds)
            {
                BackgroundColor = UIColor.White
            };
            Calendar = new FSCalendar()
            {
                Frame = new CGRect(0,
                                   NavigationController.NavigationBar.Frame.GetMaxY(),
                                   View.Frame.Width,
                                   View.Frame.Height - NavigationController.NavigationBar.Frame.GetMaxY()
                                  ),
                PagingEnabled = false,
                AllowsMultipleSelection = true,
                RowHeight = 60,
                PlaceholderType = FSCalendarPlaceholderType.None
            };
            Calendar.DataSource = this;
            Calendar.WeakDelegate = this;

            View.AddSubview(Calendar);

            Calendar.FSAppearance.TitleDefaultColor = UIColor.Black;
            Calendar.FSAppearance.HeaderTitleColor = UIColor.Black;
            Calendar.FSAppearance.TitleFont = UIFont.SystemFontOfSize(16);
            Calendar.WeekdayHeight = 0;

            Calendar.SwipeToChooseGesture.Enabled = true;

            Calendar.Today = null; // Hide the today circle
            Calendar.RegisterClass(new ObjCRuntime.Class(typeof(RangePickerCell)), "cell");
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Gregorian = new NSCalendar(NSCalendarType.Gregorian);
            DateFormatter = new NSDateFormatter()
            {
                DateFormat = "yyyy-MM-dd"
            };

            // Uncomment this to perform an 'initial-week-scope'
            //Calendar.Scope = FSCalendarScope.Week;

            // For UITest
            Calendar.AccessibilityIdentifier = "calendar";
        }

        #region FSCalendarDataSource
        [Export("minimumDateForCalendar:")]
        NSDate MinimumDateForCalendar(FSCalendar calendar)
        {
            return DateFormatter.Parse("2016-07-08");
        }
		[Export("maximumDateForCalendar:")]
		NSDate MaximumDateForCalendar(FSCalendar calendar)
        {
            return Gregorian.DateByAddingUnit(NSCalendarUnit.Month, 10, NSDate.Now, NSCalendarOptions.None);
        }

		[Export("calendar:titleForDate:")]
        string CalendarDateTitle(FSCalendar calendar, NSDate date) {
            if (Gregorian.IsDateInToday(date)) {
                return "Today";
            }
            return null;
        }

		[Export("calendar:cellForDate:atMonthPosition:")]
		FSCalendarCell CalendarCellForDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition position)
        {
            return calendar.DequeueReusableCellWithIdentifier("cell", date, position);
        }

		[Export("calendar:willDisplayCell:forDate:atMonthPosition:")]
		void CalendarWillDisplayCell(FSCalendar calendar, FSCalendarCell cell, NSDate date, FSCalendarMonthPosition monthPosition)
        {
            ConfigCell(cell, date, monthPosition);
        }
		#endregion

		#region FSCalendarDelegate
		[Export("calendar:shouldSelectDate:atMonthPosition:")]
        bool CalendarShouldSelectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition) {
            return monthPosition == FSCalendarMonthPosition.Current;
        }

		[Export("calendar:shouldDeselectDate:atMonthPosition:")]
        bool CalendarShouldDeselectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition) {
            return false;
        }

		[Export("calendar:didSelectDate:atMonthPosition:")]
        void CalendarDidSelectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition) {
            if (calendar.SwipeToChooseGesture.State == UIGestureRecognizerState.Changed)
            {
                // If the selection is caused by swipe gestures

                if (Date1 == null)
                {
                    Date1 = date;  
                }
                else {
                    if (Date2 != null) {
                        calendar.DeselectDate(Date2);
                    }
                    Date2 = date;
                }
            }
            else {
                if (Date2 != null) {
                    calendar.DeselectDate(Date1);
                    calendar.DeselectDate(Date2);
                    Date1 = date;
                    Date2 = null;
                }
                else if (Date1 == null) {
                    Date1 = date;
                }
                else {
                    Date2 = date;
                }
            }
            ConfigureVisibleCells();
        }

		[Export("calendar:didDeselectDate:atMonthPosition:")]
		void CalendarDidDeselectDate(FSCalendar calendar, NSDate date, FSCalendarMonthPosition monthPosition)
        {
            System.Diagnostics.Debug.WriteLine($"Did deselect date: {DateFormatter.ToString(date)}");
            ConfigureVisibleCells();
        }

		[Export("calendar:appearance:eventDefaultColorsForDate:")]
		UIColor[] CalendarEventDefaultColorsForDate(FSCalendar calendar, FSCalendarAppearance appearance, NSDate date)
        {
            if (Gregorian.IsDateInToday(date)) {
                return new UIColor[]{UIColor.Orange };
            }
            return new UIColor[] { appearance.EventDefaultColor };
        }
        #endregion


        private void ConfigCell(FSCalendarCell cell, NSDate date, FSCalendarMonthPosition monthPosition)
        {
            var rangeCell = cell as RangePickerCell;
            if (monthPosition != FSCalendarMonthPosition.Current)
            {
                rangeCell.MiddleLayer.Hidden = true;
                rangeCell.SelectionLayer.Hidden = true;
                return;
            }
            if (Date1 != null && Date2 != null)
            {
                // The date is in the middle of the range
                var isMiddle = date.Compare(Date1) != date.Compare(Date2);
                rangeCell.MiddleLayer.Hidden = !isMiddle;
            }
            else
            {
                rangeCell.MiddleLayer.Hidden = true;
            }
            var isSelected = false;
            isSelected |= Date1 != null && Gregorian.IsInSameDay(date, Date1);
            isSelected |= Date2 != null && Gregorian.IsInSameDay(date, Date2);
            rangeCell.SelectionLayer.Hidden = !isSelected;
		}

		private void ConfigureVisibleCells()
		{
            foreach (FSCalendarCell cell in Calendar.VisibleCells) {
                var date = Calendar.DateForCell(cell);
                var position = Calendar.MonthPositionForCell(cell);
                ConfigCell(cell, date, position);
            }
		}

    }
}

