namespace Foundation4.Models
{
    public class RunningActivity : Activity
    {
        private double _distance;

        public RunningActivity(DateTime date, int duration, double distance) : base(date, duration)
        {
            _type = "Running";
            _distance = distance;
        }

        public override double GetDistance() => _distance;
    }
}