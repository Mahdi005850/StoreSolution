using Store.BaseBackend.Models;

namespace Store.BaseBackend.Models;

public class Order : BaseModel
{
    public User user { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
    public DateTime OrderDate { get; set; }
    public Payment Payment { get; set; }
}


