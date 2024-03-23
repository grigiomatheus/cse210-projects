namespace Develop04.Models
{
    public class ListingActivity : Activity
    {
        private int _count { get; }
        private List<string> _prompts { get; }

        public ListingActivity()
        {
            base.SetName("Listing Activity");
            base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            _prompts = new List<string>()
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        public void Run()
        {
            base.Run();

            DisplayPreparationToListing();
            List<string> userAnswers = GetListFromUser();

            Console.WriteLine($"You listed {userAnswers.Count} items!");

            base.DisplayEndingMessage();
        }

        private void DisplayPreparationToListing()
        {
            string prompt = GetRandomPrompt();
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
            Console.Write("You may begin in: ");
            base.ShowCountdown(5);
            Console.WriteLine();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(0, _prompts.Count);

            return _prompts[index];
        }

        public List<string> GetListFromUser()
        {
            List<string> userAnswers = new List<string>();
            int duration = base.GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while (DateTime.Now <= endTime)
            {
                Console.Write(">");
                userAnswers.Add(Console.ReadLine());
            }

            return userAnswers;
        }
    }
}
