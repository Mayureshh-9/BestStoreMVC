using BestStoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC.Services
{
    public class ApplicationDbcontext : DbContext // Corrected the class name to PascalCase
    {
        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {
            // No need to set Products here; Entity Framework does this automatically
        }

        public DbSet<Product> Products { get; set; } // Ensure class name is capitalized
    }
}
