namespace Foundation4.Models
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _duration;
        protected string _type;

        protected Activity(DateTime date, int duration)
        {
            _date = date;
            _duration = duration;
        }

        public int GetDuration() => _duration;

        public  virtual double GetDistance() => GetSpeed() * GetDuration() / 60d;

        public virtual double GetSpeed() => (GetDistance() / GetDuration()) * 60d;

        public virtual double GetPace() => 60d / GetSpeed();

        public string GetSummary() => $"{_date:dd MMM yyyy} {_type} ({_duration} min): Distance {GetDistance().ToString("F1")} km, Speed: {GetSpeed().ToString("F1")} kph, Pace: {GetPace().ToString("F2")} min per km";
    }
}