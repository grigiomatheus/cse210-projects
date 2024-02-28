using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        bool hasParsed = int.TryParse(userInput, out int percent);

        if (hasParsed)
        {
            string grade = "";
            string sign = "";

            if (percent >= 90)
            {
                grade = "A";
            }
            else if (percent >= 80)
            {
                grade = "B";
            }
            else if (percent >= 70)
            {
                grade = "C";
            }
            else if (percent >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            if (grade != "F")
            {
                if (percent % 10 >= 7 && grade != "A")
                {
                    sign = "+";
                }
                else if (percent % 10 <= 3)
                {
                    sign = "-";
                }
            }

            Console.WriteLine($"\nYour grade is: {grade}{sign}");

            if (percent >= 70)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }
        else
        {
            Console.WriteLine("Please input a valid number.");
        }
    }
}