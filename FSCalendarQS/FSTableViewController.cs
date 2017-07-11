using Foundation;
using System;
using UIKit;

namespace FSCalendarQS
{
    public partial class FSTableViewController : UITableViewController
    {
        Type[] ViewControllers;
        public FSTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ViewControllers = new Type[] {
                typeof(RangePicker.RangePickerViewController),
                typeof(DIY.DIYExampleViewController),
                typeof(ButtonsViewController),
                typeof(HidePlacePickerViewController),
                typeof(DelegateAppearanceViewController),
                typeof(FullScreenExampleViewController),
                typeof(NSObject),
                typeof(NSObject),
                typeof(LoadViewExampleViewController)
            };

            TableView.RowHeight = UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad ? 60 : 44;
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            if (TableView.IndexPathForSelectedRow != null) {
                TableView.DeselectRow(TableView.IndexPathForSelectedRow, false);
            }
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //base.RowSelected(tableView, indexPath);
            if (ViewControllers[indexPath.Row].BaseType == typeof(UIViewController)) {
                NavigationController.PushViewController((UIViewController)Activator.CreateInstance(ViewControllers[indexPath.Row]), true);
            }
        }
    }
}