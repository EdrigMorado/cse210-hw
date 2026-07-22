using System;

class Program
{
    static void Main(string[] args)
    {
        /*
         * EXCEEDING REQUIREMENTS:
         * This program includes a library of multiple scriptures.
         * Each time the program starts, it randomly selects one scripture
         * for the user to practice.
         *
         * The program also selects only words that have not already been
         * hidden. This guarantees that new words are hidden every time
         * the user presses Enter.
         */

        //List for scripture objects
        List<Scripture> scriptureLibrary = new List<Scripture>();

        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(
            reference1,
            "For God so loved the world, that he gave his only begotten Son, " +
            "that whosoever believeth in him should not perish, but have everlasting life."
        );

        Reference reference2 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture2 = new Scripture(
            reference2,
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
            "In all thy ways acknowledge him, and he shall direct thy paths."
        );

        Reference reference3 = new Reference("Philippians", 4, 13);
        Scripture scripture3 = new Scripture(
            reference3,
            "I can do all things through Christ which strengtheneth me."
        );

        // Add scriptures to the main list
        scriptureLibrary.Add(scripture1);
        scriptureLibrary.Add(scripture2);
        scriptureLibrary.Add(scripture3);

        // Create a random generator 
        Random random = new Random();
        // Choose a random index
        int randomIndex = random.Next(scriptureLibrary.Count);

        Scripture selectedScripture = scriptureLibrary[randomIndex];

        string userInput = "";

        while (userInput.ToLower() != "quit")
        {
            Console.Clear();

            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();

            if (selectedScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            userInput = Console.ReadLine() ?? "";

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }
    }
}