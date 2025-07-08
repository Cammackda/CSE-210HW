using Program;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {


        int userResponse = -1;
        while (userResponse != 5)
        {
            Console.WriteLine("1.) Start breathingh activity\n2.) Start reflecting activity\n3.) Start listing activity\n4.) Quit\n");
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
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("That won't work; try again!");
                    break;
            }
        }
    }
}