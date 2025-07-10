public class MindfulnessActivity
{
    protected int duration;

    public void DisplayStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"---{activityName} ---");
        Console.WriteLine(description);
        Console.Write("\nHow Long (seconds) would you like to do this?");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }


    public void DisplayEndingMessage(string activityName)
    {
        Console.WriteLine($"\nGood Job! You've completed the {activityName} for {duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}