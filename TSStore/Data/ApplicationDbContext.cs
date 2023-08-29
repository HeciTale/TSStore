using Microsoft.EntityFrameworkCore;
using TSStore.Models;

namespace TSStore.Data
{
    public class ApplicationDbContext:DbContext

    {
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public ApplicationDbContext()
        {
        }
          public DbSet<Products> Product { get; set; }

    }
}
