using CleanArchWithCQRS.Domain.Models;
using CleanArchWithCQRS.Domain.Models.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchWithCQRS.Persistance
{
    public class ProjectDbContext:DbContext
    {

        public ProjectDbContext(DbContextOptions<ProjectDbContext>options):base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Tuition> Tuitions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjectDbContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                entry.Entity.ModifiedDate = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreationDate = DateTime.Now;
                }
            }
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                entry.Entity.ModifiedDate = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreationDate = DateTime.Now;
                }
            }
            return base.SaveChanges();
        }
    }
}
