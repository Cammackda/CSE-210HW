using System;
class Program
{
    public static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        int userResponse = -1;

        while (userResponse != 6)
        {
            Console.WriteLine("1.) Create Workout Plan\n");
            Console.WriteLine("2.) List Workouts\n");
            Console.WriteLine("3.) Save Workouts\n");
            Console.WriteLine("4.) Load Workouts\n");
            Console.WriteLine("5.) Record Major Event\n");
            Console.WriteLine("6.) Quit");
            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out userResponse);

            switch (userResponse)
            {
                case 1:
                    manager.CreateGoal();
                    break;
                case 2:
                    manager.DisplayGoals();
                    break;
                case 3:
                    manager.SaveGoals();
                    break;
                case 4:
                    manager.LoadGoals();
                    break;
                case 5:
                    manager.RecordEvent();
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