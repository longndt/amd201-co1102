using Microsoft.EntityFrameworkCore;
using laptop_service.Models;

namespace laptop_service.Data
{
    public class laptop_serviceContext : DbContext
    {
        public laptop_serviceContext (DbContextOptions<laptop_serviceContext> options) : base(options)
        {
        }

        public DbSet<Laptop> Laptop { get; set; } 
    }
}
