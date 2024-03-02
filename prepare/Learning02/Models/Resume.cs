namespace Learning02.Models
{
    public class Resume
    {
        public string _name { get; set; }

        public List<Job> _jobs { get; set; } = new();

        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs: ");

            _jobs.ForEach(x => x.Display());
        }
    }
}
