using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizzeria.Interfaces.Models.Products;

namespace Pizzeria.Persistence.EntityConfiguration;

public class ProductTypeEnityConfiguration : IEntityTypeConfiguration<ProductType>
{
    public void Configure(EntityTypeBuilder<ProductType> builder)
    {
        builder.HasKey(x => x.ProductTypeId);
        builder.HasIndex(x => x.Name).IsUnique();

        builder.Property(x => x.ProductTypeId).HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);

        builder.Property(x => x.NeedCooking).IsRequired();

    }
}
