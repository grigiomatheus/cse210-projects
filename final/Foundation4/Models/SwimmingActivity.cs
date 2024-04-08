namespace Foundation4.Models
{
    public class SwimmingActivity : Activity
    {
        private int _laps;

        public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration)
        {
            _type = "Swimming";
            _laps = laps;
        }

        public override double GetDistance() => (_laps * 50d) / 1000d;
    }
}