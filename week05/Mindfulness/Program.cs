using System;

// EXCEEDING REQUIREMENTS:
// In the Reflecting Activity, random reflection questions do not repeat
// until every question has been used at least once. After all questions
// have been used, the question pool is reset. This provides more variety
// during longer reflection sessions.
//
// The program also validates menu and duration input to prevent invalid
// values from causing unexpected behavior.

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");

            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity =
                        new BreathingActivity();

                    breathingActivity.Run();
                    break;

                case "2":
                    ReflectingActivity reflectingActivity =
                        new ReflectingActivity();

                    reflectingActivity.Run();
                    break;

                case "3":
                    ListingActivity listingActivity =
                        new ListingActivity();

                    listingActivity.Run();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("\nInvalid choice.");
                    Console.WriteLine("Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("\nThank you for using the Mindfulness Program.");
    }
}