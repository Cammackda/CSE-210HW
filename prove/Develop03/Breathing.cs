public class Breathing: MindfulnessActivity
{

    public void Start()
    {
        DisplayStartingMessage("This activity will help you find mental clarity",
        " as it pushes out all hectic thoughts and helps you find inner balance.");

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Breathing out...");
            Console.WriteLine();
        }


        DisplayEndingMessage("Breathing Activity");
    }
}