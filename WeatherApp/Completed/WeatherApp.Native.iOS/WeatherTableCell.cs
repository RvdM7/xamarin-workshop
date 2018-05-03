using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using WeatherApp.Core.Models;

namespace WeatherApp.Native.iOS
{
    partial class WeatherTableCell : UITableViewCell
    {
        public WeatherTableCell(IntPtr handle) : base(handle)
        {
        }

        public void UpdateData(Weather data)
        {
            TextCity.Text = data.City;
            TextTempHi.Text = data.High.ToString();
            TextTempLow.Text = data.Low.ToString();
            ImageWeather.Image = UIImage.FromBundle(data.CurrentConditions.ToString().ToLower());
        }
    }
}
