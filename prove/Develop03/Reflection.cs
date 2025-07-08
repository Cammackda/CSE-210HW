class Reflection
{

    public void DisplayPrompt(string[] args)
    {

        Random rnd = new Random();
        //if record == "Write"//

        int randomNum = rnd.Next(1 - 8);
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        if (randomNum == 1)
            Console.WriteLine("Think of a time when you stood up for someone else.");

        if (randomNum == 2)
            Console.WriteLine("Think of a time when you did something really difficult.");

        if (randomNum == 3)
            Console.WriteLine("Think of a time when you helped someone in need.");

        if (randomNum == 4)
            Console.WriteLine("Think of a time when you did something truly selfless.");
    }

    public void DisplayFollowUp(string[] args)
    {

        Random rnd = new Random();
        //if record == "Write"//

        int randomNum = rnd.Next(1 - 8);
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        if (randomNum == 1)
            Console.WriteLine("Why was this experience meaningful to you?");

        if (randomNum == 2)
            Console.WriteLine("Have you ever done anything like this before?");

        if (randomNum == 3)
            Console.WriteLine("How did you get started?");

        if (randomNum == 4)
            Console.WriteLine("How did you feel when it was complete?");

        if (randomNum == 5)
            Console.WriteLine("What made this time different than other times when you were not as successful?");

        if (randomNum == 6)
            Console.WriteLine("What is your favorite thing about this experience?");

        if (randomNum == 7)
            Console.WriteLine("What could you learn from this experience that applies to other situations?");

        if (randomNum == 8)
            Console.WriteLine("What did you learn about yourself through this experience?");
        
        if (randomNum == 9)
            Console.WriteLine("How can you keep this experience in mind in the future?");

    }
}



