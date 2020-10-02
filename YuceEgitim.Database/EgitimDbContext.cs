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
    }
}
