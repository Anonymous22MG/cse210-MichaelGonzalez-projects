using System;

class Program
{
    /*EXCEEDING REQUIREMENTS:
Added an extra activity called: Body Scan Activity that guides the user through
relaxing different parts of the body using timed prompts.
*/

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start body scan activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1")
            {
                activity = new BreathingActivity();
            }
            else if (choice == "2")
            {
                activity = new ReflectionActivity();
            }
            else if (choice == "3")
            {
                activity = new ListingActivity();
            }
            else if (choice == "4")
            {
                activity = new BodyScanActivity();
            }
            else if (choice == "5")
            {
                // quit
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue...");
                Console.ReadLine();
            }

            if (activity != null)
            {
                activity.Run();
            }
        }
    }
}