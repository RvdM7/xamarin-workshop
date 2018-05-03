using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;
using WeatherApp.Core.Models;
using WeatherApp.Core.ViewModels;

namespace WeatherApp.Native.iOS
{
	partial class WeatherTVC : UITableViewController
	{
		const string CELL_ID = "cell_id";
		Weather[] data;

		public WeatherTVC (IntPtr handle) : base (handle)
		{
            data = new WeatherViewModel().Forecast;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			TableView.ContentInset = new UIEdgeInsets (20, 0, 0, 0);
		}
		
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell (CELL_ID);

			if (cell == null) {
				cell = new UITableViewCell (UITableViewCellStyle.Default, CELL_ID);
			}

			cell.TextLabel.Text = data [indexPath.Row].ToString ();

			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return data.Length;
		}
	}
}
