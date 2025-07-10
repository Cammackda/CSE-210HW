using System.Security.Cryptography.X509Certificates;

public class Reflection : MindfulnessActivity
{
        private string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

    private string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    public void Start()
    {
        DisplayStartingMessage("Reflection Activity",
        "This activity will help you reflect on times you were strong.");

        Random rnd = new Random();
        Console.WriteLine("\n" + prompts[rnd.Next(prompts.Length)]);
        Console.WriteLine("Reflect on the following questions:\n");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(questions[rnd.Next(questions.Length)] + " ");
            ShowSpinner(3);
            Console.WriteLine();
        }

        DisplayEndingMessage("Reflection Activity");

    }

}



