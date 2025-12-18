namespace Store.BaseBackend.Models;
public class Product : BaseModel
{
    public required string Name { get; set; }
    public required string Type { get; set; }
    public required string Color { get; set; }
    public double Width { get; set; } 
    public double PricePerColor{ get; set; }
    public double Stock { get; set; }
    public string ProductType { get; }
    public int ID { get; internal set; }
}
