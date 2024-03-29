using Develop05.Services;

class Program
{
    static void Main(string[] args)
    {
        //To creativity criteria I added some validations on the program like TryGetValidInput().

        Console.WriteLine("Welcome to the Eternal Quest Program.");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}