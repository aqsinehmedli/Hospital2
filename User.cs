namespace Hospital__registration;

public class Users
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Users(int id, string name, string email, string phone)
    {
        Id = id;
        Name = name;
        Email = email;
        Phone = phone;
    }
    public Users()
    {
        
    }
    public override string ToString()=>
        $"Id:{Id}\nName:{Name}\nEmail:{Email}\nPhone{Phone}";

}
