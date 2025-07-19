using System;
namespace ProductReview
{
    public class Review
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

    public override string ToString()
        {
            return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }
    }

public class Input
{
    private static readonly String[] prompts = new string[]
    {
            "Why should consumers purchase a Tesla?",
            "Why should consumers purchase a hot tub?",
            "When should consumers invest in Silver? Why?",
            "What are the benefits of *health company* to consumers?",
            "What brand of bottled water is the best? Why?",

    };

    public Review CreateResponse()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, prompts.Length);
        string selectedPrompt = prompts[index];
        string dateText = DateTime.Now.ToShortDateString();

        Console.WriteLine(selectedPrompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        return new Review
        {
            Date = dateText,
            Prompt = selectedPrompt,
            Response = response
        };
    }
    };

}
