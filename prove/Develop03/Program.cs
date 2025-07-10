using Program;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {


        int userResponse = -1;

        while (userResponse != 4)
        {
            Console.WriteLine("1.) Start Breathing Activity\n2.) Start Reflecting Activity\n3.) Start Listing Activity\n4.) Quit\n");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out userResponse);

            switch (userResponse)
            {
                case 1:
                    new Breathing().Start();
                    break;
                case 2:
                    new Reflection().Start();
                    break;
                case 3:
                    new Listing().Start();
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("That won't work; try again!");
                    break;
            }

            Console.WriteLine("\nPress Enter to Return to the Menu");
            Console.ReadLine();
        }
    }
}