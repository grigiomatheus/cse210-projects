namespace Foundation4.Models
{
    public class CyclingActivity : Activity
    {
        private double _speed;

        public CyclingActivity(DateTime date, int duration, double speed) : base(date, duration)
        {
            _type = "Cycling";
            _speed = speed;
        }

        public override double GetSpeed() => _speed;
    }
}