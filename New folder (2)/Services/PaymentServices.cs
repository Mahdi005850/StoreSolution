using Store.BaseBackend.Models;
using Store.BaseBackend.Interface;

namespace Store.BaseBackend.Models;

internal class PaymentServices : IBaseService<Payment>
{
    protected List<Payment> items = new List<Payment>();
    public void Add(Payment item)
    {
        items.Add(item);
    }
    public void Delete(Payment item)
    {
        items.Remove(item);
    }
    public List<Payment> GetAll()
    {
        return items;
    }
    public void Reset(Payment item)
    {
        items.Clear();
    }
    public void Update(Payment item)
    {
        throw new NotImplementedException();
    }
}
