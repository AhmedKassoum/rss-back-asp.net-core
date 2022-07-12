using rss_back.Models;

namespace rss_back.Services
{
    public interface IItem
    {
        public IEnumerable<Item> GetAll();
        public Item GetByGuid(string guid);
        public Item Create(Item item);
        public void Delete(string guid);
    }
}
