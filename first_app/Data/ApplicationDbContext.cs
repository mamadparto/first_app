using Microsoft.EntityFrameworkCore;
using first_app.Models;

namespace first_app.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductViewModel> Products { get; set; }
        // Add other DbSet properties for your models here
    }
}
