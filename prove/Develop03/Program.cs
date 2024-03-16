using Develop03.Models;
using Develop03.Services;

class Program
{
    static void Main(string[] args)
    {
        ScriptureService scriptureService = new ScriptureService();
        Scripture scripture = scriptureService.GetRandomScripture();
        Random random = new Random();

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            var userInput = Console.ReadLine();

            if (userInput.ToLowerInvariant() == "quit")
                break;

            scripture.HideRandomWords(random.Next(1, 3));
        }
    }
}