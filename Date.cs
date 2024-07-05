namespace Hospital__registration;

public class Date
{

    public string Day { get; set; }
    public string Month { get; set; }
    public string Year { get; set; }
    public string Hour { get; set; }
    public string Minute { get; set; }

    public Date(string day, string month, string year, string hour, string minute)
    {
        Day = day;
        Month = month;
        Year = year;
        Hour = hour;
        Minute = minute;
    }

    public override string ToString() =>
        $"{Day}/{Month}/{Year}\nTime:{Hour}:{Minute}";

}
