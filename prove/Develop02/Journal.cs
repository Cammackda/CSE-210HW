using System.Security.Cryptography;

namespace Journal;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Johnny!");
        Console.WriteLine("");
        Console.WriteLine("What would you like to do today? (Please Spell Correctly)");
        string record = Console.ReadLine();
        Console.WriteLine(record);
    }
}

