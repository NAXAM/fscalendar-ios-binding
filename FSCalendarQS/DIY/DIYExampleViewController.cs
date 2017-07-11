using System;
using UIKit;
using FSCalendar;
using Foundation;
using CoreGraphics;
using System.Linq;

namespace FSCalendarQS.DIY
{
    public class DIYExampleViewController: UIViewController, IFSCalendarDelegate, IFSCalendarDataSource, IFSCalendarDelegateAppearance
    {
        FSCalendarView Calendar;
        NSCalendar Gregorian;
        NSDateFormatter DateFormatter;
        UILabel EventLabel;

		public DIYExampleViewController(IntPtr handle) : base(handle)
		{
		}

        public DIYExampleViewController(): base()
        {
            Title = "DIY Example";
		}

        public override void LoadView()
        {
            View = new UIView(UIScreen.MainScreen.Bounds)
            {
                BackgroundColor = UIColor.GroupTableViewBackgroundColor
            };

            var height = UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad ? 450 : 300;

            Calendar = new FSCalendarView()
            {
                Frame = new CGRect(0, NavigationController.NavigationBar.Frame.GetMaxY(), View.Frame.Width, height),
                DataSource = this,
                WeakDelegate = this,
                AllowsMultipleSelection = true
            };
            Calendar.SwipeToChooseGesture.Enabled = true;
            View.AddSubview(Calendar);

            Calendar.CalendarHeaderView.BackgroundColor = UIColor.LightGray.ColorWithAlpha(0.1f);
            Calendar.CalendarWeekdayView.BackgroundColor = UIColor.LightGray.ColorWithAlpha(0.1f);
            Calendar.CalendarAppearance.EventSelectionColor = UIColor.White;
            Calendar.CalendarAppearance.EventOffset = new CGPoint(0, -7);
            Calendar.Today = null; // Hide the today circle
            Calendar.RegisterClass(new ObjCRuntime.Class(typeof(DIYCalendarCell)), "cell");
            var scopeGesture = new UIPanGestureRecognizer( (UIPanGestureRecognizer obj) => {
                Calendar.HandleScopeGesture(obj);   
            });
            Calendar.AddGestureRecognizer(scopeGesture);

            EventLabel = new UILabel(new CGRect(0, Calendar.Frame.GetMaxY() + 10, View.Frame.Width, 50)) {
                TextAlignment = UITextAlignment.Center,
                Font = UIFont.GetPreferredFontForTextStyle(UIFontTextStyle.Subheadline)
            };
            View.AddSubview(EventLabel);

            var attributedText = new NSMutableAttributedString("");
            var attatchment = new NSTextAttachment()
            {
                Image = UIImage.FromBundle("icon_cat")
            };
            attatchment.Bounds = new CGRect(0, -3, attatchment.Image.Size.Width, attatchment.Image.Size.Height);
            attributedText.Append(NSAttributedString.FromAttachment(attatchment));
            attributedText.Append(new NSAttributedString(" This is a daily event "));
            attributedText.Append(NSAttributedString.FromAttachment(attatchment));
            EventLabel.AttributedText = attributedText;                                  
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Gregorian = new NSCalendar(NSCalendarType.Gregorian);
			DateFormatter = new NSDateFormatter()
			{
				DateFormat = "yyyy-MM-dd"
			};

            Calendar.SelectDate(Gregorian.DateByAddingUnit(NSCalendarUnit.Day, -1, NSDate.Now, NSCalendarOptions.None), false);
            Calendar.SelectDate(NSDate.Now, false);
            Calendar.SelectDate(Gregorian.DateByAddingUnit(NSCalendarUnit.Day, 1, NSDate.Now, NSCalendarOptions.None), false);

			// Uncomment this to perform an 'initial-week-scope'
			//Calendar.Scope = FSCalendarScope.Week;

			// For UITest
			Calendar.AccessibilityIdentifier = "calendar";
		}

		#region FSCalendarDataSource
		[Export("minimumDateForCalendar:")]
		NSDate MinimumDateForCalendar(FSCalendarView calendar)
		{
			return DateFormatter.Parse("2016-07-08");
		}
		[Export("maximumDateForCalendar:")]
		NSDate MaximumDateForCalendar(FSCalendarView calendar)
		{
			return Gregorian.DateByAddingUnit(NSCalendarUnit.Month, 5, NSDate.Now, NSCalendarOptions.None);
		}

		[Export("calendar:titleForDate:")]
		string CalendarDateTitle(FSCalendarView calendar, NSDate date)
		{
			if (Gregorian.IsDateInToday(date))
			{
				return "Today";
			}
			return null;
		}

		[Export("calendar:cellForDate:atMonthPosition:")]
		FSCalendarCell CalendarCellForDate(FSCalendarView calendar, NSDate date, FSCalendarMonthPosition position)
		{
			return calendar.DequeueReusableCellWithIdentifier("cell", date, position);
		}

		[Export("calendar:willDisplayCell:forDate:atMonthPosition:")]
		void CalendarWillDisplayCell(FSCalendarView calendar, FSCalendarCell cell, NSDate date, FSCalendarMonthPosition monthPosition)
		{
			ConfigCell(cell, date, monthPosition);
		}

		[Export("calendar:numberOfEventsForDate:")]
        nint CalendarDateNumberOfEvents(FSCalendarView calendar, NSDate date) {
            return new Random().Next(0, 3);
        }
		#endregion

		#region FSCalendarDelegate
		[Export("calendar:boundingRectWillChange:animated:")]
        void CalendarBoundingRectWillChange(FSCalendarView calendar, CGRect bounds, bool animated) {
            calendar.Frame = new CGRect(calendar.Frame.Location, bounds.Size);
            EventLabel.Frame = new CGRect(0, calendar.Frame.GetMaxY() + 10, View.Frame.Width, 50);
        }

		[Export("calendar:shouldSelectDate:atMonthPosition:")]
        bool CalendarShouldSelectDate(FSCalendarView calendar, NSDate date, FSCalendarMonthPosition monthPosition) {
            return monthPosition == FSCalendarMonthPosition.Current;
        }

		[Export("calendar:shouldDeselectDate:atMonthPosition:")]
        bool CalendarShouldDeselectDate(FSCalendarView calendar, NSDate date, FSCalendarMonthPosition monthPosition) {
            return monthPosition == FSCalendarMonthPosition.Current;
        }

		[Export("calendar:didSelectDate:atMonthPosition:")]
        void CalendarDidSelectDate(FSCalendarView calendar, NSDate date, FSCalendarMonthPosition monthPosition) {
            System.Diagnostics.Debug.WriteLine($"Did select date: {DateFormatter.ToString(date)}");
            ConfigureVisibleCells();
        }

		[Export("calendar:didDeselectDate:atMonthPosition:")]
        void CalendarDidDeselectDate(FSCalendarView calendar, NSDate date, FSCalendarMonthPosition monthPosition) {
            System.Diagnostics.Debug.WriteLine($"Did deselect date: {DateFormatter.ToString(date)}");
            ConfigureVisibleCells();
        }

		[Export("calendar:appearance:eventDefaultColorsForDate:")]
		UIColor[] CalendarEventDefaultColorsForDate(FSCalendarView calendar, FSCalendarAppearance appearance, NSDate date)
		{
			if (Gregorian.IsDateInToday(date))
			{
				return new UIColor[] { UIColor.Orange };
			}
			return new UIColor[] { appearance.EventDefaultColor };
		}

        #endregion


        private void ConfigCell(FSCalendarCell cell, NSDate date, FSCalendarMonthPosition monthPosition)
		{
            var diyCell = cell as DIYCalendarCell;

            // Custom today circle
            diyCell.CircleImageView.Hidden = !Gregorian.IsDateInToday(date);

			// Configure selection layer
            if (monthPosition == FSCalendarMonthPosition.Current) {
                var selectionType = SelectionType.None;
                if (Calendar.SelectedDates.Contains(date)) {
                    var previousDate = Gregorian.DateByAddingUnit(NSCalendarUnit.Day, -1, date, NSCalendarOptions.None);
                    var nextDate = Gregorian.DateByAddingUnit(NSCalendarUnit.Day, 1, date, NSCalendarOptions.None);
                    if (Calendar.SelectedDates.Contains(previousDate) && Calendar.SelectedDates.Contains(nextDate)) {
                        selectionType = SelectionType.Middle;
                    }
                    else if (Calendar.SelectedDates.Contains(previousDate)) {
                        selectionType = SelectionType.RightBorder;
                    }
                    else if (Calendar.SelectedDates.Contains(nextDate)) {
                        selectionType = SelectionType.LeftBorder;
                    }
                    else {
                        selectionType = SelectionType.Single;
                    }
				}
                else {
                    selectionType = SelectionType.None;
                }

                diyCell.SelectionType = selectionType;
                diyCell.SelectionLayer.Hidden = selectionType == SelectionType.None;
            }
            else {
                diyCell.CircleImageView.Hidden = true;
                diyCell.SelectionLayer.Hidden = true;
            }
		}

		private void ConfigureVisibleCells()
		{
			foreach (FSCalendarCell cell in Calendar.VisibleCells)
			{
				var date = Calendar.DateForCell(cell);
				var position = Calendar.MonthPositionForCell(cell);
				ConfigCell(cell, date, position);
			}
		}
    }
}
