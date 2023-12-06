namespace Project_Take_two.Models
{
    public class MemoryTravelService : ITravelService
    {
        private Dictionary<int, Travel> _items = new Dictionary<int, Travel>();
        IDateTimeProvider _timeProvider;

        public MemoryTravelService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public int Add(Travel item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            item.Created = _timeProvider.Actual();
            _items.Add(item.Id, item);
            return item.Id;
        }

        public int Count()
        {
            return _items.Count;
        }
        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<Travel> FindAll()
        {
            return _items.Values.ToList();
        }

        public Travel? FindById(int id)
        {
            return _items[id];
        }

        public void Update(Travel item)
        {
            _items[item.Id] = item;
        }
    }
}
