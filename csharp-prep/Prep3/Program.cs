using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);
            int guessQuantity = 0;

            while (true)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                bool isValidNumber = int.TryParse(guessInput, out int guessNumber);

                if (isValidNumber)
                {
                    guessQuantity++;

                    if (guessNumber > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (guessNumber < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! You made it in {guessQuantity} times!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Please enter a number.\n");
                }
            }

            Console.Write("\nDo you want to play again? (yes/no) ");
            string playAgainInput = Console.ReadLine();

            if(playAgainInput.ToLower() == "no")
            {
                break;
            }
            else
            {
                Console.Clear();
            }
        }
    }
}