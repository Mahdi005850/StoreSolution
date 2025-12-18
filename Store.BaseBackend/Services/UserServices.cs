using Store.BaseBackend.Interface;

namespace Store.BaseBackend.Models;

public class UserServices : IBaseService<User>
{
    protected List<User> items = new List<User>();
    public void Add(User item)
    {
        items.Add(item);
    }
    public void Delete(User item)
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

    public User? Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<User> GetAll()
    {
        return items;
    }
    public void Update(User item)
    {
        var itemFromDatabase = Get(item.Id);
        if (itemFromDatabase is null) return;

        itemFromDatabase.FirstName = item.FirstName;
        itemFromDatabase.LastName = item.LastName;
        itemFromDatabase.BirthDate = item.BirthDate;
        itemFromDatabase.NationalCode = item.NationalCode;
        itemFromDatabase.Email = item.Email;
        itemFromDatabase.Adress = item.Adress;
        
    }
}
