using System;
using FSCalendar;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Foundation;

namespace FSCalendarQS.RangePicker
{
    public class RangePickerCell: FSCalendarCell
    {
        public CALayer SelectionLayer;
        public CALayer MiddleLayer;

		public RangePickerCell(IntPtr handle) : base(handle)
        {
            Setup();
		}

        public RangePickerCell(CGRect frame): base(frame)
        {
            Setup();
        }

        private void Setup()
        {
			SelectionLayer = new CALayer()
			{
				BackgroundColor = UIColor.Orange.CGColor,
				Actions = NSDictionary.FromObjectAndKey(
					NSNull.Null,
					(NSString)"hidden" // Remove hiding animation
				)
			};
			ContentView.Layer.InsertSublayerBelow(SelectionLayer, TitleLabel.Layer);

			MiddleLayer = new CALayer()
			{
				BackgroundColor = UIColor.Orange.ColorWithAlpha(0.3f).CGColor,
				Actions = NSDictionary.FromObjectAndKey(
					NSNull.Null,
					(NSString)"hidden" // Remove hiding animation
				)
			};
            ContentView.Layer.InsertSublayerBelow(MiddleLayer, TitleLabel.Layer);

			ShapeLayer.Hidden = true;
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            TitleLabel.Frame = ContentView.Bounds;
        }

        public override void LayoutSublayersOfLayer(CALayer layer)
        {
            base.LayoutSublayersOfLayer(layer);
            SelectionLayer.Frame = ContentView.Bounds;
            MiddleLayer.Frame = ContentView.Bounds;
        }
    }
}
