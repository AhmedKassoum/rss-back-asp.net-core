using Microsoft.EntityFrameworkCore;
using rss_back.Models;

namespace rss_back.Context
{
    public class RSSContext : DbContext
    {
        public RSSContext(DbContextOptions<RSSContext> options)
        : base(options)
        {
        }

        public DbSet<Item> Items => Set<Item>();
    }
}
