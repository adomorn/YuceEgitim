using System;
using Microsoft.EntityFrameworkCore;
using YuceEgitim.Entites;

namespace YuceEgitim.Database
{
    public class EgitimDbContext : DbContext
    {
        public EgitimDbContext(DbContextOptions options ) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is ISilinebilinir)
                {
                    switch (entry.State)
                    {
                        case EntityState.Detached:
                            break;
                        case EntityState.Unchanged:
                            break;
                        case EntityState.Deleted:
                            entry.State = EntityState.Modified;
                            entry.CurrentValues["Silindi"] = true;
                            break;
                        case EntityState.Modified:
                            break;
                        case EntityState.Added:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
            return base.SaveChanges();
        }
    }
}
