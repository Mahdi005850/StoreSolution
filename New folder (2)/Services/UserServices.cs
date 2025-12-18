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
    public List<User> GetAll()
    {
        return items;
    }
    public void Reset(User item)
    {
        items.Clear();
    }
    public void Update(User item)
    {

    }
}
