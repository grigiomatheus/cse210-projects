namespace Foundation3.Models
{
    public class LectureEvent : Event
    {
        private string _speaker;
        private int _capacity;

        public LectureEvent(string title, string description, DateTime date, TimeSpan duration, Address address, string speaker, int capacity)
            : base(title, description, date, duration, address)
        {
            _type = "Lecture Event";
            _speaker = speaker;
            _capacity = capacity;
        }

        public override string GenerateFullMessage()
        {
            string standardMessage = base.GenerateStandardMessage();
            standardMessage += $"\nSpeaker: {_speaker} \nCapacity: {_capacity}";
            return standardMessage;
        }
    }
}