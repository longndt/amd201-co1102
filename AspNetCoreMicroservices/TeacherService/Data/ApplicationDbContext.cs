using Microsoft.EntityFrameworkCore;

using TeacherService.Models;

namespace TeacherService.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
    {
    }

    public DbSet<Teacher> Teachers { get; set; }
  }
}
