namespace Foundation3.Models
{
    public abstract class Event
    {
        private string _title;
        protected string _type;
        private string _description;
        private DateTime _date;
        private TimeSpan _duration;
        private Address _address;
 
        protected Event(string title, string description, DateTime date, TimeSpan duration, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _duration = duration;
            _address = address;
        }

        // Lists the title, description, date, time, and address.
        public string GenerateStandardMessage() => $"Title: {_title}\nDescription:{_description}\nDate: {_date}\nDuration: {_duration} \nAddress: {_address.GetAddress()}";

        //Lists all of the above, plus type of event and information specific to that event type.
        //For lectures, this includes the speaker name and capacity.
        //For receptions this includes an email for RSVP.
        //For outdoor gatherings, this includes a statement of the weather.
        public abstract string GenerateFullMessage();

        //Lists the type of event, title, and the date.
        public string GenerateShortMessage() => $"Type: {_type} \nTitle: {_title} \nDate: {_date}";
    }
}