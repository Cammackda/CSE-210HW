using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Reference object for John 3:16
        Reference reference = new Reference("John", 3, 16);

        // Create a Famous Quote Object
        string scriptureText = "Do or do not, there is no try. ";

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
