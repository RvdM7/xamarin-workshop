using System;

using Xamarin.Forms;
using WeatherApp.Core.Models;

namespace WeatherApp.Core.ViewModels
{
    public class WeatherViewModel
    {
        public WeatherViewModel()
        {
            Forecast = new[] {
                new Weather { City = "San Fransisco", Temperature = 50, High = 55, Low = 45, CurrentConditions = Conditions.Windy},
                new Weather { City = "Seattle", Temperature = 40, High = 46, Low = 33, CurrentConditions = Conditions.Rain },
                new Weather { City = "Vancouver", Temperature = 52, High = 53, Low = 46, CurrentConditions = Conditions.Cloudy },
                new Weather { City = "Washington DC", Temperature = 70, High = 75, Low = 55, CurrentConditions = Conditions.Sunny },
                new Weather { City = "Boston", Temperature = 40, High = 41, Low = 33, CurrentConditions = Conditions.Snow },
                new Weather { City = "Virginia Beach", Temperature = 75, High = 79, Low = 70, CurrentConditions = Conditions.Rainbow },

                new Weather { City = "Farmington", Temperature = 75, High = 79, Low = 65, CurrentConditions = Conditions.Sunny },
                new Weather { City = "Richardson", Temperature = 75, High = 79, Low = 66, CurrentConditions = Conditions.Cloudy },
                new Weather { City = "Buddina", Temperature = 75, High = 79, Low = 67, CurrentConditions = Conditions.Windy },
                new Weather { City = "Phoenix", Temperature = 75, High = 79, Low = 68, CurrentConditions = Conditions.Rain },
                new Weather { City = "Brunswick", Temperature = 75, High = 79, Low = 62, CurrentConditions = Conditions.Sunny },
                new Weather { City = "Cape Town", Temperature = 75, High = 79, Low = 65, CurrentConditions = Conditions.Cloudy },
                new Weather { City = "Haidholzen", Temperature = 75, High = 79, Low = 72, CurrentConditions = Conditions.Windy },

                new Weather { City = "Los Angeles", Temperature = 75, High = 79, Low = 70, CurrentConditions = Conditions.Sunny },
            };
        }

        public Weather[] Forecast { get; set; }
    }
}

