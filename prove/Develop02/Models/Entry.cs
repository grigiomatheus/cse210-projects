namespace Develop02.Models
{
    public class Entry
    {
        public Guid _id { get; set; } = Guid.NewGuid();

        public string _promptText { get; set; }

        public string _entryText { get; set; }

        public DateTime _date { get; set; } = DateTime.Now;

        public bool isAlreadySaved { get; set; } = false;

        public void Display()
        {
            Console.WriteLine($"Date: {_date.ToString("MM/dd/yyyy")} - Prompt: '{_promptText}'");
            Console.WriteLine($"Answer: {_entryText}\n");
        }
    }
}