using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class ProductTypeEnityConfiguration : IEntityTypeConfiguration<ProductType>
{
    public void Configure(EntityTypeBuilder<ProductType> builder)
    {
        //builder.Property(x => x.ProductTypeId).HasConversion(x => x.ToGuid(), x => new Ulid(x));

    }
}
