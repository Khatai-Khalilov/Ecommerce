using Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ecommerce.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ecommerce.db ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.ApplyConfiguration(new AppUserConfiguration);
            modelBuilder.ApplyConfiguration(new BrandConfiguration);

            Əlavə etdiyimiz konfiqurasiya siniflərini burada tanımlamalıyıq
                        amma belə tək-tək etmək yerinə aşağıdakı üsullarla edə bilərik.

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
            */

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
