namespace Hospital__registration;

public class WrongBranch:Exception
{
    public WrongBranch(string message) : base(message) { }
    public WrongBranch()
            : base("Bele bir Sobe yoxdur!") { }
}
