using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class ShopEnityConfiguration : IEntityTypeConfiguration<Shop>
{
    public void Configure(EntityTypeBuilder<Shop> builder)
    {
        //builder.Property(x => x.ShopId).HasConversion(x => x.ToGuid(), x => new Ulid(x));

    }
}
