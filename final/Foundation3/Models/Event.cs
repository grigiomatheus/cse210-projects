namespace Foundation3.Models
{
    public abstract class Event
    {
        private string _name;
        private string _description;
        private DateTime _date;
        private TimeSpan _duration;
        private Address _address;

        public virtual void GenerateStandardMessage()
        {

        }

        public virtual void GenerateFullMessage()
        {

        }

        public virtual void GenerateShortMessage()
        {

        }
    }
}