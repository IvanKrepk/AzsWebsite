using Microsoft.EntityFrameworkCore;

namespace AzsWebsite.Models
{
    public class AzsDbContext : DbContext
    {
        public AzsDbContext(DbContextOptions<AzsDbContext> options) : base(options)
        {
        }

        public DbSet<NewsItem> News { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
