using Microsoft.EntityFrameworkCore;
using first_app.Models;

namespace first_app.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public required DbSet<Product> Products { get; set; }
        // Add other DbSet properties for your models here
    }
}
