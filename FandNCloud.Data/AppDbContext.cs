using FandNCloud.Core.Models;
using FandNCloud.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FandNCloud.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new UserConfiguration());
        }
    }
}