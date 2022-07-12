using Microsoft.EntityFrameworkCore;
using rss_back.Context;
using rss_back.Models;
namespace rss_back.Services
{
    public class ItemService : IItem
    {
        private readonly RSSContext _context;
        public ItemService(RSSContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> GetAll()
        {
            return _context.Items
                .Include(it=>it.Content)
                .Include(it=>it.Image)
                .Include(it=>it.Creator)
                .AsNoTracking()
                .ToList();
        }

        public Item GetByGuid(string guid)
        {   
            return _context.Items
                .Include(it => it.Image)
                .Include(it=>it.Content)
                .Include(it=>it.Creator)
                .SingleOrDefault(it => it.Guid.ToString().Equals(guid));
        }

        public Item Create(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Item Update(string guid, Item item)
        {
            var oldItem = GetByGuid(guid);
            if (oldItem is not null)
            {
                oldItem.Title = item.Title;
                oldItem.Category = item.Category;
                oldItem.Date = item.Date;
                oldItem.DateType = item.DateType;
                oldItem.Creator = item.Creator;
                oldItem.Content = item.Content;
                oldItem.Image = item.Image;
            }
            _context.SaveChanges();
            return oldItem;
        }

        public void Delete(string guid)
        {
            var item = GetByGuid(guid);
            if(item is not null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();  
            }
        }
    }
}
