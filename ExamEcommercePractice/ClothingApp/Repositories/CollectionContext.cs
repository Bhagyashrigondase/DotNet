using ClothingApp.Entities;
using Microsoft.EntityFrameworkCore;
namespace ClothingApp.Repositories
{
    public class CollectionContext: DbContext
    {
        //1.declare DBSet<>
        //2.Override OnConfiguring and OnModelCreating

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=localhost;Port=3306;User=root;Password=Gondase@123;Database=EcommerceDotnet";
            optionsBuilder.UseMySQL(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Name);
                entity.Property(p => p.Description);
                entity.Property(p => p.Price);
                entity.Property(p => p.Quantity);
            }
            );

            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}
