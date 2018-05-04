using System;
using System.Collections.Generic;
using WeatherApp.Core.ViewModels;
using Xamarin.Forms;

namespace WeatherApp.Core
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new WeatherViewModel();
        }
    }
}
