using Store.BaseBackend.Interface;

namespace Store.BaseBackend.Models;

public class StoreServices : IBaseService<Store>
{

    protected List<Store> items = new List<Store>();
    public void Add(Store item)
    {
        items.Add(item);
    }
    public void Delete(Store item)
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

    public Store? Get(int id)
    {
        return items.SingleOrDefault(c => c.Id == id);
    }

    public List<Store> GetAll()
    {
        return items;
    }
    public void Update(Store item)
    {
        var itemFromDatabase = Get(item.Id);
        if (itemFromDatabase is null) return;

        itemFromDatabase.NameBrand = item.NameBrand;
        itemFromDatabase.Telephone = item.Telephone;
        itemFromDatabase.PostalCode = item.PostalCode;
        itemFromDatabase.Address = item.Address;
        itemFromDatabase.User = item.User;
    }
}
