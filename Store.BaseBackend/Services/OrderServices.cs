using Store.BaseBackend.Interface;

namespace Store.BaseBackend.Models;

public class OrderServices : IBaseService<Order>
{
    protected List<Order> items = new List<Order>();
    public void Add(Order item)
    {
        items.Add(item);
    }
    public void Delete(Order item)
    {
        items.Remove(item);
    }
    public void Delete(int id)
    {
        // var item = items.SingleOrDefault(c => c.Id == id);
        var item = Get(id);
        if(item is not null)
        {
            // items.Remove(item);
            Delete(item);
        }
    }
    public Order? Get(int id)
    {
        return items.SingleOrDefault(c => c.Id == id);
    }
    public List<Order> GetAll()
    {
        return items;
    }
    public void Reset(Order item)
    {
        items.Clear();
    }
    public void Update(Order item)
    {
        var itemFromDatabase = Get(item.Id);
        if(itemFromDatabase is  null) return;

        // 01 - Bad 
        // Delete(itemFromDatabase);
        // Add(item);

        // 02 - Good update
        itemFromDatabase.OrderDate = item.OrderDate;
        itemFromDatabase.Payment = item.Payment;
        itemFromDatabase.Products = item.Products;
        // TODO: Mehdi please complete this
    }
}
