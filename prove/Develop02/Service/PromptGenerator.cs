namespace Develop02.Service
{
    public static class PromptGenerator
    {
        private static List<string> _prompts => new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the most interesting thing I learned today?",
            "What are you grateful for?",
            "What are you worried about?",
            "What are you looking forward to?",
            "What are you proud of?",
            "What are you excited about?"
        };

        public static string GenerateRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}
