using System;
using ProductReview;
using DescriptionInput;
namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        Input  entryCreator = new Input();

        Description description = new Description();

        int userResponse = -1;
        while (userResponse != 5)
        {
            Console.WriteLine("1.) Write\n2.) Display\n3.) Load\n4.) Save\n5.) Quit\n");
            userResponse = int.Parse(Console.ReadLine());

            switch (userResponse)
            {
                case 1:
                    Review newReview = entryCreator.CreateResponse();
                    description.AddEntry(newReview);
                    break;
                case 2:
                    description.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename to load from: ");
                    string loadFile = Console.ReadLine();
                    description.LoadFromFile(loadFile);
                    break;
                case 4:
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    description.SaveToFile(saveFile);
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