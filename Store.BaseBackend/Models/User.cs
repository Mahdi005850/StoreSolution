namespace Store.BaseBackend.Models;
public class User : BaseModel
{
    public User()
    {
    }
    public User(string nationalCode, string phoneNumber)
    {
        if (string.IsNullOrEmpty(nationalCode))
        {
            throw new ArgumentNullException("National code is null or empty");
        }

        if (string.IsNullOrEmpty(phoneNumber))
        {
            throw new ArgumentNullException("Phone number is null or empty");
        }

        NationalCode = nationalCode;
        PhoneNumber = phoneNumber;
    }
    public User(string nationalCode, string phoneNumber, string firstName, string lastName, string adress) : this(nationalCode, phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Adress = adress;

    }
    //ShortHand Property 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Adress { get; set; }
    public string NationalCode { get; set; }

    public DateTime BirthDate { get; set; }
    public int Age
    {
        get
        {
            if (BirthDate == DateTime.MinValue)
            {
                throw new Exception("Birth Date is invalid");
            }
            return DateTime.Now.Year - BirthDate.Year;
        }
    }

    //Full Property
    private int _email; // Field 
    private DateTime _birthDate;
    private static List<Order> orders = new();
    public int Email
    {
        get { return _email; }
        set { _email = value; }
    }

}

