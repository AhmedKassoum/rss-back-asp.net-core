using rss_back.Context;
using rss_back.Models;
namespace rss_back.Services
{
    public class ItemService
    {
        private readonly RSSContext _context;
        public ItemService(RSSContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> GetAll()
        {
            return _context.Items.ToList();
        }

        public Item GetByGuid(Guid guid)
        {
            return _context.Items.SingleOrDefault(it => it.Guid == guid);
        }

        public Item Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public void Delete(Guid guid)
        {
            var item = _context.Items.Find(guid);
            if(item is not null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
