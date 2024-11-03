using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class ProductEnityConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.ProductId);

        builder.HasIndex(x => x.ProductTypeId);
        builder.HasIndex(x => x.Name).IsUnique();


        builder.Property(x => x.ProductId)
            .HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.ProductTypeId)
            .HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(1000);
        builder.Property(x => x.Price).IsRequired().HasPrecision(15, 6);

    }
}

