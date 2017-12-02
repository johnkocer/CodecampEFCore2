using Microsoft.EntityFrameworkCore;

namespace CodeFirst
{
   public class DataContext : DbContext
   {
      public DataContext(DbContextOptions<DataContext> options) : base(options) { }

      public DbSet<Employee> Employee { get; set; }
      public DbSet<Department> Department { get; set; }

      //protected override void OnModelCreating(ModelBuilder builder)
      //{
      //   base.OnModelCreating(builder);
      //}
   }
}
