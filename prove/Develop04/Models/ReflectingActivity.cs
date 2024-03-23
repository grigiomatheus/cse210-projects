namespace Develop04.Models
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts { get; }
        private List<Question> _questions { get; }
        public ReflectingActivity()
        {
            base.SetName("Reflection Activity");
            base.SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

            _prompts = new List<string>()
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };

            _questions = new List<Question>()
            {
                new Question("Why was this experience meaningful to you? "),
                new Question("Have you ever done anything like this before? "),
                new Question("How did you get started? "),
                new Question("How did you feel when it was complete? "),
                new Question("What made this time different than other times when you were not as successful? "),
                new Question("What is your favorite thing about this experience? "),
                new Question("What could you learn from this experience that applies to other situations? "),
                new Question("What did you learn about yourself through this experience? "),
                new Question("How can you keep this experience in mind in the future? "),
                new Question("What would you do differently next time? "),
                new Question("What would you do the same next time? "),
                new Question("What are you most proud of in this experience? "),
                new Question("What was the most challenging part of this experience? "),
                new Question("What was the most rewarding part of this experience? "),
                new Question("What was the most surprising part of this experience? "),
            };
        }

        public void Run()
        {
            base.Run();
            DisplayPrompt();
            DisplayPreparationToReflection();
            ReflectOnExperience();
            base.DisplayEndingMessage();
        }

        private void DisplayPreparationToReflection()
        {
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            base.ShowCountdown(5);
        }

        private void ReflectOnExperience()
        {
            Console.Clear();

            int duration = base.GetDuration();
            DateTime endTime = DateTime.Now.AddSeconds(duration);

            while(DateTime.Now < endTime)
            {
                DisplayQuestion();
                ShowSpinner(5);
                Console.WriteLine();
            }
        }

        private string GetRandomQuestion()
        {
            Random random = new Random();
            List<Question> questionsNotShown = _questions.Where(x => !x.IsAlreadyShowed()).ToList();
            int questionNotShownCount = questionsNotShown.Count;

            if(questionNotShownCount == 0)
                return "No more questions to show. ";
            
            int index = random.Next(0, questionsNotShown.Count);
            Question questionToShow = questionsNotShown[index];

            _questions
                .Find(x => x.GetGuid() == questionToShow.GetGuid())
                .SetAlreadyShowed();

            return questionToShow.GetQuestion();
        }

        private string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(0, _prompts.Count);

            return _prompts[index];
        }

        private void DisplayPrompt()
        {
            var prompt = GetRandomPrompt();

            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine($"\n--- {prompt} ---\n");
        }

        private void DisplayQuestion()
        {
            var question = GetRandomQuestion();
            Console.Write(question);
        }
    }
}
