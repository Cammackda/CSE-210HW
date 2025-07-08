class Breathing
{

    public void DisplayQuestion(string[] args)
    {
        Console.WriteLine("This activity will help you find mental clarity as it pushes out all hectic thoughts and helps you find inner balance.");
        Thread.Sleep(1000);
        Console.WriteLine("The excersize will begin. In 3 seconds.");
        Console.Write("+");
        Thread.Sleep(3000);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character

        Console.WriteLine("Breathe in...");
        Thread.Sleep(2000);
        Console.WriteLine("Breathe out...");
        Thread.Sleep(2000);
        Console.WriteLine("Breathe in...");
        Thread.Sleep(2000);
        Console.WriteLine("Breathe out...");
        Thread.Sleep(2000);
    }
}