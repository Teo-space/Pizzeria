using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class OrderPositionEnityConfiguration : IEntityTypeConfiguration<OrderPosition>
{
    public void Configure(EntityTypeBuilder<OrderPosition> builder)
    {
        //builder.Property(x => x.OrderPositionId).HasConversion(x => x.ToGuid(), x => new Ulid(x));
        //builder.Property(x => x.OrderId).HasConversion(x => x.ToGuid(), x => new Ulid(x));
        //builder.Property(x => x.ProductId).HasConversion(x => x.ToGuid(), x => new Ulid(x));
        //builder.Property(x => x.ProductTypeId).HasConversion(x => x.ToGuid(), x => new Ulid(x));

    }
}
