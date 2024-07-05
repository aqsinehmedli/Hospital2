namespace Hospital__registration;

public class WrongDoctor : Exception
{
    public WrongDoctor(string message) : base(message) { }
    public WrongDoctor()
            : base("Bele bir hekim yoxdur!") { }

}
