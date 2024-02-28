using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numberList = new List<int>();

        while (true)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            bool hasParsed = int.TryParse(userInput, out int number);

            if (hasParsed)
            {
                if (number == 0)
                {
                    break;
                }

                numberList.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine($"The sum is: {numberList.Sum()}");
        Console.WriteLine($"The average is: {numberList.Average()}");
        Console.WriteLine($"The largest number is: {numberList.Max()}");
        Console.WriteLine($"The smallest positive number is {numberList.Where(x => x > 0).Min()}");
        Console.WriteLine("The sorted list is:");

        numberList.Sort();

        foreach (int number in numberList)
        {
            Console.WriteLine(number);
        }
    }
}