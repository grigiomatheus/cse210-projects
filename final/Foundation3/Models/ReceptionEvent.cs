namespace Foundation3.Models
{
    public class ReceptionEvent : Event
    {
        private string _rsvpEmail;

        public ReceptionEvent(string title, string description, DateTime date, TimeSpan duration, Address address, string rsvpEmail)
            : base(title, description, date, duration, address)
        {
            _type = "Reception Event";
            _rsvpEmail = rsvpEmail;
        }

        public override string GenerateFullMessage()
        {
            string standardMessage = base.GenerateStandardMessage();
            standardMessage += $"\nRSVP Email: {_rsvpEmail}";
            return standardMessage;
        }
    }
}