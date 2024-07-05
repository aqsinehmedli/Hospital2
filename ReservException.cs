namespace Hospital__registration;

public class ReservException:Exception
{
    public ReservException(string message) : base(message) { }
    public ReservException()
            : base("Bu tarix rezerv olunub") { }
}
