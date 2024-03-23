namespace Develop04.Models
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            base.SetName("Breathing Activity");
            base.SetDescription("This activity will help you relax by walking your through breathing in and out slowly.\n\nClear your mind and focus on your breathing.");
        }

        public void Run()
        {
            base.Run();

            DisplayBreathInAndOut();

            base.DisplayEndingMessage();
        }

        private void DisplayBreathInAndOut()
        {
            int duration = base.GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            bool isFirstInteraction = true;
            int breathInTime = 2;
            int breathOutTime = 3;

            while(DateTime.Now < endTime)
            {
                Console.WriteLine("\n");
                Console.Write("Breathe in...");
                base.ShowCountdown(breathInTime);

                Console.WriteLine();
                Console.Write("Now breathe out...");
                base.ShowCountdown(breathOutTime);

                if (isFirstInteraction)
                {
                    breathInTime = 4;
                    breathOutTime = 6;
                    isFirstInteraction = false;
                }
            }

            Console.WriteLine();
        }
    }
}
