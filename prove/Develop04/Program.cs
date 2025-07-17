using System;
class Program
{
    public static void Main(string[] args)
    {


        int userResponse = -1;

        while (userResponse != 6)
        {
            Console.WriteLine("1.) Create New Goal\n");
            Console.WriteLine("2.) List Goals\n");
            Console.WriteLine("3.) Save Goals\n");
            Console.WriteLine("4.) Load Goals\n");
            Console.WriteLine("5.) Record Event\n");
            Console.WriteLine("6.) Quit");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out userResponse);

            switch (userResponse)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
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