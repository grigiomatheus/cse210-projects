using Develop02.Models;
using Develop02.Service;
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            DisplayMenu();
            bool couldParse = int.TryParse(Console.ReadLine(), out int selectedOption);

            if (!couldParse)
            {
                DisplayErrorMessage("\nInvalid input. Please try again.");
                continue;
            }

            switch (selectedOption)
            {
                case 1:
                    string prompt = PromptGenerator.GenerateRandomPrompt();
                    Console.WriteLine(prompt);

                    string userAnswer = Console.ReadLine();

                    journal.AddEntry(new Entry
                    {
                        _promptText = PromptGenerator.GenerateRandomPrompt(),
                        _entryText = userAnswer
                    });

                    break;
                case 2:
                    journal.DisplayAll();
                    Console.Write("Select the number of the entry that you want remove: ");

                    bool couldParseIndex = int.TryParse(Console.ReadLine(), out int indexToRemove);

                    if (!couldParseIndex)
                    {
                        DisplayErrorMessage("Invalid input. Please try again.");
                        break;
                    }

                    journal.RemoveEntry(indexToRemove - 1);

                    break;
                case 3:
                    journal.DisplayAll();
                    break;
                case 4:
                    Console.WriteLine("Input the name of the file that you want to load: ");
                    bool fileEncountred = journal.LoadFromFile(Console.ReadLine());

                    if (fileEncountred)
                        DisplaySucessMessage("File loaded with success!");
                    else
                        DisplayErrorMessage("Sorry, file not found.");

                    break;
                case 5:
                    Console.WriteLine("Input the name of the file that you want to save: ");
                    string journalName = Console.ReadLine();

                    journal.SaveToFile(journalName);

                    DisplaySucessMessage("Journal saved with success!");
                    break;
                case 6:
                    journal.DisplayFiles();
                    break;
                case 7:
                    Console.Clear();
                    break;
                case 8:
                    Console.WriteLine("Quit");
                    return;
                default:
                    DisplayErrorMessage("Invalid input. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("\nPlease select one of the following choices:");
        Console.WriteLine("1. Write an entry");
        Console.WriteLine("2. Remove an entry");
        Console.WriteLine("3. Display all the entries");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Save");
        Console.WriteLine("6. Display all files");
        Console.WriteLine("7. Clear screen");
        Console.WriteLine("8. Quit");
        Console.Write("What would you like to do? ");
    }

    private static void DisplaySucessMessage(string message)
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.Write(message);

        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }

    private static void DisplayErrorMessage(string message)
    {
        Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write(message);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
    }
}