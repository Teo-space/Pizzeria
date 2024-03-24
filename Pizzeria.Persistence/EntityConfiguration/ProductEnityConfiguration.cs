using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class ProductEnityConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        //builder.Property(x => x.ProductId).HasConversion(x => x.ToGuid(), x => new Ulid(x));
        //builder.Property(x => x.ProductTypeId).HasConversion(x => x.ToGuid(), x => new Ulid(x));

    }
}
