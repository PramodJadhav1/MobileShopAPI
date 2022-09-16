using Microsoft.EntityFrameworkCore;
using MobileShopAPI.Model;

namespace MobileShopAPI.Entities
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer>? Customer { get; set; }
        public DbSet<Brand>? Brand { get; set; }

        public DbSet<PlaceOrder>? PlaceOrder { get; set; }
    }
}

