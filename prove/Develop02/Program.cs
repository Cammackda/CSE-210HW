namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        int userResponse = -1;
        while (userResponse != 5)
        {
            Console.WriteLine("1.) Write\n 2.) Display\n 3.) Load\n 4.) Save\n 5.) Quit\n");
            userResponse = int.Parse(Console.ReadLine());

            switch (userResponse)
            {
                case 1:
                    Console.WriteLine("Write");
                    
                    break;
                case 2:
                    Console.WriteLine("Display");
                    break;
                case 3:
                    Console.WriteLine("Load");
                    break;
                case 4:
                    Console.WriteLine("Save");
                    break;
                case 5:
                    Console.WriteLine("Quit");
                    break;
            }
        }
    }
}