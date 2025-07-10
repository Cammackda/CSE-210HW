using System.Runtime.CompilerServices;

public class Listing : MindfulnessActivity
{

    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"  ,
        };

    public void Start()
    {
        DisplayStartingMessage("Listing Activity",
        "This activity will help you list and remember good things in our life and lift your mind!");

        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nYou have a few seconds to think...");
        Countdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        List<string> userResponses = new List<string>();

        Console.WriteLine("Start listing your items (press Enter after each):");

        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    userResponses.Add(input);
                }
            }
        }

        Console.WriteLine($"\nYou listed {userResponses.Count} items. ");

        DisplayEndingMessage("Listing Activity");
    }

    



}
