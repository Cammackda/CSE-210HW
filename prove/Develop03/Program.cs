using Program;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {


        int userResponse = -1;
        while (userResponse != 5)
        {
            Console.WriteLine("1.) Start Breathing Activity\n2.) Start Reflecting Activity\n3.) Start Listing Activity\n4.) Quit\n");
            userResponse = int.Parse(Console.ReadLine());
            
            switch (userResponse)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
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