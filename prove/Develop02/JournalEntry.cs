using System.Security.Cryptography;

namespace JournalEntry;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        //if record == "Write"//
        int randomNum = rnd.Next(1 - 8);
        if (randomNum == 1)
            Console.WriteLine("What was your favorite thing about today?");
        if (randomNum == 2)
            Console.WriteLine("What was the weather like?");
        if (randomNum == 3)
            Console.WriteLine("What was hardest about today?");
        if (randomNum == 4)
            Console.WriteLine("Who impacted you the most?");
        if (randomNum == 5)
            Console.WriteLine("What are you most grateful for today?");
        if (randomNum == 6)
            Console.WriteLine("How will you take what you learned todya into tomorrow?");
        if (randomNum == 7)
            Console.WriteLine("What do you want to do again tomorrow that you did today?");
        if (randomNum == 8)
            Console.WriteLine("Who did you help today?");
        else
            Console.Write("Error; Please Type input again");
        
    }
}