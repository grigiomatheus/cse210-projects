using System;

namespace Foundation3.Models
{
    public class OutdoorGatheringEvent : Event
    {
        private string _weatherForecast;

        public OutdoorGatheringEvent(string title, string description, DateTime date, TimeSpan duration, Address address, string wheaterForecast)
            :base(title, description, date, duration, address)
        {
            _type = "Outdoor Gathering Event";
            _weatherForecast = wheaterForecast;
        }

        public override string GenerateFullMessage()
        {
            string standardMessage = base.GenerateStandardMessage();
            standardMessage += $"\nWeather Forecast: {_weatherForecast}";
            return standardMessage;
        }
    }
}