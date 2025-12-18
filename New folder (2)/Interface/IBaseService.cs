using Store.BaseBackend.Models;

namespace Store.BaseBackend.Interface;

public interface IBaseService<T> where T : BaseModel
{
    public void Add(T item);
    List<T> GetAll();
    T? Get(int id);
    public void Delete(T item);
    void Delete(int id);
    // public void Delete(int id);
    // public void Delete(IEnumerable<int> ids);
    public void Update(T item);
    public void Reset(T item);
}
