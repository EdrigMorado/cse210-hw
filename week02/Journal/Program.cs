// I added file validation when loading a journal.
// If the user enters a filename that does not exist, the program displays an error message
// instead of crashing. I also added confirmation messages after saving and loading files.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to your Personal Journal!");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userInput = "";

        while (userInput != "5")
        {
            // Display Menu 
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            // Take user entry
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            // Main menu logic
            if (userInput == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine($"[+] {prompt}");
                Console.Write("> ");

                string userAnswer = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = userAnswer;

                journal.AddEntry(entry);

            }
            else if (userInput == "2")
            {
                journal.DisplayJournal();
            }
            else if (userInput == "3")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (userInput == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                
                journal.SaveToFile(filename);
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again");
            }

            Console.WriteLine("");
        }
    }
}