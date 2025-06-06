class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bob", "Lemi", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Crocker", 23, "Bat");
        //Console.WriteLine(myPoliceMan.GetPersonInformation)
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());
    }
}

