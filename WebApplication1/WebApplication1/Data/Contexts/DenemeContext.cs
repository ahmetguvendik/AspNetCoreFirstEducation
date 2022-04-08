using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Configurations;
using WebApplication1.Data.Entities;
using static WebApplication1.Data.Entities.Employee;

namespace WebApplication1.Data.Contexts
{
    public class DenemeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<SaleHistory> SaleHistories { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PartTimeEmployee> partTimeEmployees { get; set; }
        public DbSet<FullTimeEmployee> fullTimeEmployees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-A523NCQ\\MSSQLSERVER01; database=WebApplication1; integrated security=true");
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            
            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.CategoryId, x.ProductId }); //ikisini primary key yapmak için
           
            modelBuilder.Entity<Catagory>().HasMany(x => x.ProductCategory).WithOne(x => x.Catagory).HasForeignKey(x => x.CategoryId); //ManyToMany
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployee");
            modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployee"); //Eğer böyle üçünü ayrı şekilde yazarsak bu sefer hepsi için ayrı tablo oluşturur.
            base.OnModelCreating(modelBuilder);
            //FluentApi yaklaşımı ilgili Tablo Adı değiştirme.
        }

    }
    
}
