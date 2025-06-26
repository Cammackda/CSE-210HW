using System;
namespace JournalEntry
{
    public class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

    public override string ToString()
        {
            return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }
    }

public class JournalEntry
{
    private static readonly String[] prompts = new string[]
    {
            "What was your favorite thing about today?",
            "What was the weather like?",
            "What was hardest about today?",
            "Who impacted you the most?",
            "What are you most grateful for today?",
            "How will you take what you learned today into tomorrow?",
            "What do you want to do again tomorrow that you did today?",
            "Who did you help today?"

    };

    public Entry CreateJournal()
    {
        Random rnd = new Random();
        int index = rnd.Next(0, prompts.Length);
        string selectedPrompt = prompts[index];
        string dateText = DateTime.Now.ToShortDateString();

        Console.WriteLine(selectedPrompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        return new Entry
        {
            Date = dateText,
            Prompt = selectedPrompt,
            Response = response
        };
    }
    };

}
