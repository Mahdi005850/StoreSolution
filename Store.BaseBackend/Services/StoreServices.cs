using Store.BaseBackend.Interface;

namespace Store.BaseBackend.Models
{
    internal class StoreServices : IBaseService<Store>
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
        public List<Store> GetAll()
        {
            return items;
        }
        public void Reset(Store item)
        {
            items.Clear();
        }
        public void Update(Store item)
        {
            
        }
    }
}
