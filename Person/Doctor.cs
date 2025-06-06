class Doctor : Person
{

    private string _tools;
    public Doctor(string firstName, string lastName, int age)
    : base(firstName, lastName, age)
    {
        _tools = tools;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }
}