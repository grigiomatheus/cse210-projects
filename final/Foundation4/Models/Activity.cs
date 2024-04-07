namespace Foundation4.Models
{
    public abstract class Activity
    {
        private DateTime _date;
        private int _duration;

        public virtual double GetDistance()
        {
            throw new NotImplementedException();
        }

        public virtual double GetSpeed()
        {
            throw new NotImplementedException();
        }

        public virtual double GetPace()
        {
            throw new NotImplementedException();
        }

        public string GetSummary()
        {
            throw new NotImplementedException();
        }
    }
}