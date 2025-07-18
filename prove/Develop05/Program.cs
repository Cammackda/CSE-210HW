using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Reference object for John 3:16
        Reference reference = new Reference("John", 3, 16);

        // Create a Scripture object with the reference and scripture text
        string scriptureText = "For God so loved the world that he gave his one and only Son, " +
                               "that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(reference, scriptureText);

        bool allHidden = false;

        while (!allHidden)
        {
            scripture.Display();

            Console.WriteLine("\nPress ENTER to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 random words each round
            int wordsToHide = 3;

            allHidden = scripture.HideRandomWords(wordsToHide);
        }

        Console.WriteLine("All words are hidden. Goodbye!");
    }
}
