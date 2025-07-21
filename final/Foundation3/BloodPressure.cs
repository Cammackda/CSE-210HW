using System.Runtime.CompilerServices;

public class BloodPressure
{

    private string[] prompts = {
        "What is your daistolic reading and what does it mean?",
        "What is your systolic reading and what does it mean?",
        
        };

    public void Start()
    {
        Console.WriteLine("Listing Activity",
        "This activity will help you record your blood pressure and understand more about what the numbers mean.");

        Random rnd = new Random();
        string prompt = prompts[rnd.Next(prompts.Length)];
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nYou have a few seconds to think...");
        

        

        Console.WriteLine("Start taking your second reading.");

    

        Console.WriteLine("Blood Pressure Activity.");
    }

    



}
