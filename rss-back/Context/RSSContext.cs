using Microsoft.EntityFrameworkCore;
using rss_back.Models;

namespace rss_back.Context
{
    public class RSSContext : DbContext
    {
        public DbSet<Item> Items => Set<Item>();

        public RSSContext()
        {

        }
        public RSSContext(DbContextOptions<RSSContext> options)
        : base(options)
        {
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=RSS;Trusted_Connection=True;");
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .HasKey(it=>it.Guid);

            modelBuilder.Entity<ImageType>()
                .Property(img => img.Type)
                .HasConversion<string>();

            modelBuilder.Entity<ContentType>()
                .Property(c => c.Type)
                .HasConversion<string>();

            modelBuilder.Entity<CreatorType>()
                .Property(cr => cr.Type)
                .HasConversion<string>();
        }

    }
}
