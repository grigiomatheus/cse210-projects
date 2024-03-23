using Develop04.Models;

class Program
{
    static void Main(string[] args)
    {
        /*
         * The program exceeds the core requirements by not showing the same question twice in the Reflecting Activity.
         */

        while (true)
        {
            DisplayMenu();
            string input = Console.ReadLine();

            if(int.TryParse(input, out int result))
            {
                switch (result)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Run();
                        break;
                    case 2:
                        ReflectingActivity reflectingActivity = new ReflectingActivity();
                        reflectingActivity.Run();
                        break;
                    case 3:
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Run();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice. Please try again.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid choice. Please try again.\n");
            }
        }
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("     1. Start breathing activity");
        Console.WriteLine("     2. Start reflection Activity");
        Console.WriteLine("     3. Start listing activity");
        Console.WriteLine("     4. Quit");
        Console.Write("Select a choice from the menu: ");
    }
}