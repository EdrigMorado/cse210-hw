using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userInput = "";

        while (userInput != "5")
        {
            // Display Menu 
            Console.WriteLine("Welcome to your Personal Journal!");
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
                Console.WriteLine("Load selected");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Save selected");
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again");
            }

            Console.WriteLine("");
        }
        
        
    }
}