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

    public void Delete(int id)
    {
        var item = Get(id);
        if (item is not null)
        {
            Delete(item);
        }
    }

    public Product? Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        return items;
    }
    public void Update(Product item)
    {
        var itemFromDatabase = Get(item.Id);
        if (itemFromDatabase is null) return;

        itemFromDatabase.Color= item.Color;
        itemFromDatabase.Name = item.Name;
        itemFromDatabase.PricePerColor = item.PricePerColor;
        itemFromDatabase.Type = item.Type;
        itemFromDatabase.Stock = item.Stock;
        itemFromDatabase.Width = item.Width;

    }
}
