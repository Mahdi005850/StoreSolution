using Store.BaseBackend.Interface;

namespace Store.BaseBackend.Models;
public class PaymentServices : IBaseService<Payment>
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

    public void Delete(int id)
    {
        var item = Get(id);
        if (item is not null)
        {
            Delete(item);
        }
    }

    public Payment? Get(int id)
    {
        throw new NotImplementedException();
    }

    public List<Payment> GetAll()
    {
        return items;
    }
    public void Update(Payment item)
    {
        var itemFromDatabase = Get(item.Id);
        if (itemFromDatabase is null) return;

        itemFromDatabase.PaymentDateTime = item.PaymentDateTime;
        itemFromDatabase.Amount = item.Amount;
        itemFromDatabase.Status = item.Status;
        itemFromDatabase.PaymentType = item.PaymentType;
        itemFromDatabase.IsCompleted = item.IsCompleted;
    }
}
