using Microsoft.EntityFrameworkCore;

namespace ProdsCats.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Association> Associations { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}