class PoliceMan : Person
{

    private string _weapons;
    public PoliceMan(string firstName, string lastName, int age)
    : base(firstName, lastName, age)
    {
        _weapons = _weapons;
    }

    public string GetDoctorManInformation()
    {
        return $"Weapons: {_weapons} :: {GetDoctorInformation()}";
    }
}