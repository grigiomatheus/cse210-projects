namespace Develop04.Models
{
    public class Activity
    {
        private string _name;
        private string _description;
        private int _duration;

        public Activity(){}

        public void SetName(string name) => _name = name;

        public void SetDescription(string description) => _description = description;

        public void SetDuration()
        {
            while(true)
            {
                Console.Write("\nHow long, in seconds, would you like for your session? ");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    _duration = result;
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please try again.");
                }
            }
        }

        public int GetDuration() => _duration;

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name}.\n");
            Console.WriteLine(_description);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nWell done!");
            ShowSpinner(3);
            Console.WriteLine($"\nYou have complete {_duration} seconds of the {_name}.");
            ShowSpinner(5);
            Console.Clear();
        }

        public void ShowSpinner(int seconds)
        {
            string[] sequence = new string[] { "|", "/", "-", "\\"};
            DateTime endSpinnerTime = DateTime.Now.AddSeconds(seconds);

            while (DateTime.Now < endSpinnerTime)
            {
                foreach (string item in sequence)
                {
                    Console.Write(item);
                    Thread.Sleep(700);
                    Console.Write("\b \b");
                }
            }
        }

        public void ShowCountdown(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write(seconds - i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public void Run()
        {
            DisplayStartingMessage();
            SetDuration();
            DisplayGetReady();
        }

        private void DisplayGetReady()
        {
            Console.Clear();
            Console.WriteLine("Get ready...");
            ShowSpinner(5);

            Console.WriteLine();
        }
    }
}
