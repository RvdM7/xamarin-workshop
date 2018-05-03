using System;
using System.Collections.Generic;

namespace WeatherApp.Core.Models
{
    public enum Conditions
    {
        Sunny,
        Cloudy,
        Windy,
        Rain,
        Snow,
        Rainbow,
        count
    }

    public class Weather
    {
        public string City { get; set; }
        public float Temperature { get; set; }
        public float High { get; set; }
        public float Low { get; set; }
        public Conditions CurrentConditions { get; set; }

        public override string ToString()
        {
            return String.Format("{0}: {1}°F ( high:{2}° low:{3}° )", CurrentConditions.ToString(), Temperature, High, Low);
        }
    }
}

