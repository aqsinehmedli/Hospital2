namespace Hospital__registration;

public class Doctors
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public Branch BranchName { get; set; }
    public int experience { get; set; }
    public Doctors(string name, string surname, Branch branchName)
    {
        Name = name;
        Surname = surname;
        BranchName = branchName;
    }

    public Doctors(string name, string surname, Branch branchName, int experience) : this(name, surname, branchName)
    {
        this.experience = experience;
    }

    public override string ToString() =>
        $"Name:{Name}\nSurname:{Surname}\nBranchName{BranchName}\nExperience:{experience}";
}
