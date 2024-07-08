using Microsoft.EntityFrameworkCore;

using StudentService.Models;

namespace StudentService.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
  }
}
