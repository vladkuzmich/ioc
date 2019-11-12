using Microsoft.EntityFrameworkCore;
using IoC.Data.Entities;
using IoC.Data.EntityTypeConfigurations;

namespace IoC.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}