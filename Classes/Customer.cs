namespace Classes;

public class Customer
{
    public int Id { get; set; }
    private string _firstName;
    public string FirstName
    { //encapsulation
        get {return "Mrs." + _firstName;}
        set {_firstName = value;}
    }
    public string LastName { get; set; }
    public string City { get; set; }

}
