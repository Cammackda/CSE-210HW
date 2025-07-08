class Reflection
{

    public void DisplayPrompt(string[] args)
    {
        Console.WriteLine("This activity will help you reflect on previous experiences that will help find strength and happiness.");
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
            Thread.Sleep(3000);
        if (randomNum == 2)
            Console.WriteLine("Have you ever done anything like this before?");
            Thread.Sleep(3000);
        if (randomNum == 3)
            Console.WriteLine("How did you get started?");
            Thread.Sleep(3000);
        if (randomNum == 4)
            Console.WriteLine("How did you feel when it was complete?");
            Thread.Sleep(3000);
        if (randomNum == 5)
            Console.WriteLine("What made this time different than other times when you were not as successful?");
            Thread.Sleep(3000);
        if (randomNum == 6)
            Console.WriteLine("What is your favorite thing about this experience?");
            Thread.Sleep(3000);
        if (randomNum == 7)
            Console.WriteLine("What could you learn from this experience that applies to other situations?");
            Thread.Sleep(3000);
        if (randomNum == 8)
            Console.WriteLine("What did you learn about yourself through this experience?");
            Thread.Sleep(3000);
        if (randomNum == 9)
            Console.WriteLine("How can you keep this experience in mind in the future?");
            Thread.Sleep(3000);
    }
}



