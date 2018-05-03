using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;
using WeatherApp.Core.ViewModels;
using WeatherApp.Core.Models;

namespace WeatherApp.Native.iOS
{
    partial class WeatherTVC : UITableViewController
    {
        const string CELL_ID = "cell_id";
        Weather[] data;

        public WeatherTVC(IntPtr handle) : base(handle)
        {
            data = new WeatherViewModel().Forecast;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TableView.ContentInset = new UIEdgeInsets(20, 0, 0, 0);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (WeatherTableCell)tableView.DequeueReusableCell(CELL_ID);

            cell.UpdateData(data[indexPath.Row]);

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return data.Length;
        }



    }
}
