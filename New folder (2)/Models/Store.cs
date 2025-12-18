namespace Store.BaseBackend.Models;

public class Store : BaseModel
{
    public required string NameBrand { get; set; }
    public required string Telephone { get; set; }
    public string PostalCode { get; set; }
    public string Address { get; set; }
    public User User { get; set; }
}
