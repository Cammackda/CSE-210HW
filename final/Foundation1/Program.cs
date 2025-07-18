using System;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        JournalEntry.JournalEntry entryCreator = new JournalEntry.JournalEntry();

        Journal journal = new Journal();

        int userResponse = -1;
        while (userResponse != 5)
        {
            Console.WriteLine("1.) Write\n2.) Display\n3.) Load\n4.) Save\n5.) Quit\n");
            userResponse = int.Parse(Console.ReadLine());

            switch (userResponse)
            {
                case 1:
                    Entry newEntry = entryCreator.CreateJournal();
                    journal.AddEntry(newEntry);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
                case 4:
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("That won't work; try again!");
                    break;
            }
        }
    }
}