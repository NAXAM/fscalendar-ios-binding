using System;
using CoreAnimation;
using FSCalendarAbstractions;
using UIKit;
using CoreGraphics;
using Foundation;

namespace FSCalendarQS.DIY
{
    public enum SelectionType
    {
        None,
        Single,
        LeftBorder,
        Middle,
        RightBorder
    }

    public class DIYCalendarCell : FSCalendarCell
    {
        public UIImageView CircleImageView;
        public CAShapeLayer SelectionLayer;
        private SelectionType _SelectionType;

        public SelectionType SelectionType
        {
            get { return _SelectionType; }
            set
            {
                if (value != _SelectionType)
                {
                    _SelectionType = value;
                    SetNeedsLayout();
                }
            }
        }

        public DIYCalendarCell(IntPtr handle) : base(handle)
        {
            Setup();
        }

        public DIYCalendarCell(CGRect frame) : base(frame)
        {
            Setup();
        }

        private void Setup()
        {
            CircleImageView = new UIImageView(UIImage.FromBundle("circle"));
            ContentView.InsertSubview(CircleImageView, 0);

            SelectionLayer = new CAShapeLayer()
            {
                FillColor = UIColor.Black.CGColor,
                Actions = NSDictionary.FromObjectAndKey(NSNull.Null, (NSString)"hidden")
            };
            ContentView.Layer.InsertSublayerBelow(SelectionLayer, TitleLabel.Layer);

            ShapeLayer.Hidden = true;
            BackgroundView = new UIView(this.Bounds);
            BackgroundView.BackgroundColor = UIColor.LightGray.ColorWithAlpha(0.1f);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            BackgroundView.Frame = Bounds.Inset(1, 1);
            CircleImageView.Frame = BackgroundView.Frame;
            SelectionLayer.Frame = Bounds;

            switch (SelectionType)
            {
                case SelectionType.Middle:
                    SelectionLayer.Path = UIBezierPath.FromRect(SelectionLayer.Bounds).CGPath;
                    break;
                case SelectionType.LeftBorder:
                    SelectionLayer.Path = UIBezierPath.FromRoundedRect(SelectionLayer.Bounds,
                        UIRectCorner.TopLeft | UIRectCorner.BottomLeft,
                        new CGSize(SelectionLayer.GetFs_width() / 2, SelectionLayer.GetFs_width() / 2)
                        ).CGPath;
                    break;
                case SelectionType.RightBorder:
                    SelectionLayer.Path = UIBezierPath.FromRoundedRect(SelectionLayer.Bounds,
                        UIRectCorner.TopRight | UIRectCorner.BottomRight,
                        new CGSize(SelectionLayer.GetFs_width() / 2, SelectionLayer.GetFs_width() / 2)
                        ).CGPath;
                    break;
                case SelectionType.Single:
                    var diameter = Math.Min(SelectionLayer.GetFs_height(), SelectionLayer.GetFs_width());
                    SelectionLayer.Path = UIBezierPath.FromOval(new CGRect(SelectionLayer.GetFs_width() / 2 - diameter / 2,
                        SelectionLayer.GetFs_height() / 2 - diameter / 2,
                        diameter,
                        diameter
                        )).CGPath;
                    break;
                default:
                    break;
            }
        }

        public override void ConfigureAppearance()
        {
            base.ConfigureAppearance();
            if (Placeholder)
            {
                TitleLabel.TextColor = UIColor.LightGray;
                EventIndicator.Hidden = true;
            }
        }
    }
}