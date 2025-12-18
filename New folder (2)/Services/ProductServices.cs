using Store.BaseBackend.Interface;

namespace Store.BaseBackend.Models;

public class ProductServices : IBaseService<Product>
{
    protected List<Product> items = new List<Product>();
    public void Add(Product item)
    {
        items.Add(item);
    }
    public void Delete(Product item)
    {
        items.Remove(item);
    }

    public List<Product> GetAll()
    {
        return items;
    }
    public void Reset(Product item)
    {
        items.Clear();
    }
    public void Update(Product item)
    {
        
    }
}
