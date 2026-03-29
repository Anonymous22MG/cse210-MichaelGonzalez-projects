using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding requirements: I added a leveling system to make the program more like a game.
        // The user levels up every 1000 points, and the program also displays
        // a small congratulation message when points are earned

        GoalManager manager = new GoalManager();

        string choice = "";

        while (choice != "6")
        {
            Console.Clear();
            manager.DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine() ?? "";

            Console.WriteLine();

            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.ListGoalDetails();
            }
            else if (choice == "3")
            {
                manager.SaveGoals();
            }
            else if (choice == "4")
            {
                manager.LoadGoals();
            }
            else if (choice == "5")
            {
                manager.RecordEvent();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }

            if (choice != "6")
            {
                Console.WriteLine();
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}