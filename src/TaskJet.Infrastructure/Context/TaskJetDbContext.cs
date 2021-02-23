using Microsoft.EntityFrameworkCore;
using System.Linq;
using TaskJet.Domain.Models;

namespace TaskJet.Infrastructure
{
    public class TaskJetDbContext : DbContext
    {
        public TaskJetDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(string))))
                property.SetColumnType("varchar(150)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskJetDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
