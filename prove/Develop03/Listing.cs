class Listing
{
    
    public void DisplayQuestion(string[] args)
    {

        Random rnd = new Random();
        //if record == "Write"//
        
        int randomNum = rnd.Next(1 - 8);
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        if (randomNum == 1)
            Console.WriteLine("Who are people that you appreciate?");

        if (randomNum == 2)
            Console.WriteLine("What are personal strengths of yours?");

        if (randomNum == 3)
            Console.WriteLine("Who are people that you have helped this week?");

        if (randomNum == 4)
            Console.WriteLine("When have you felt the Holy Ghost this month?");
            
        if (randomNum == 5)
            Console.WriteLine("Who are some of your personal heroes?");           
    }
}