using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.WriteLine("\nWhat is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}