using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data.Configurations
{

    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasDefaultValueSql("'Girilmemis'");
            builder.Property(x => x.CreatedDate).HasDefaultValueSql("getdate()");
            builder.HasIndex(x => x.Name).IsUnique(true);
            builder.HasMany(x => x.SaleHistory).WithOne(x => x.Product).HasForeignKey(x => x.ProductId); //OnetoMany
            builder.HasOne(x => x.ProductDetail).WithOne(x => x.Product).HasForeignKey<ProductDetail>(x => x.ProductId); //OneToOne. ForeignKey içine yazmamızın sebebi foreign keyi hangisinden alacağımızı söylememiz gerek.
            builder.HasMany(x => x.ProductCategory).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);  //ManyToMany
            throw new NotImplementedException();
        }
    }
}
