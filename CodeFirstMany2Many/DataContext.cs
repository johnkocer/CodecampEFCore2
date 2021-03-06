﻿using Microsoft.EntityFrameworkCore;

namespace CodeFirst
{
   public class DataContext : DbContext
   {
      public DataContext(DbContextOptions<DataContext> options) : base(options) { }

      public DbSet<Employee> Employee { get; set; }
      public DbSet<Project> Project { get; set; }


      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<EmployeeProject>()
            .HasKey(p => new { p.EmployeeId, p.ProlectId });

         modelBuilder.Entity<EmployeeProject>()
                     .HasOne(ep => ep.Employee) // Mark Address property optional in Student entity
                     .WithMany(ad => ad.EmployeeProject) // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
                     .HasForeignKey(ep => ep.EmployeeId);

         modelBuilder.Entity<EmployeeProject>()
                     .HasOne(ep => ep.Project) // Mark Address property optional in Student entity
                     .WithMany(ad => ad.EmployeeProject) // mark Student property as required in StudentAddress entity. Cannot save StudentAddress without Student
                     .HasForeignKey(ep => ep.ProlectId);

         base.OnModelCreating(modelBuilder);
      }
   }
}
