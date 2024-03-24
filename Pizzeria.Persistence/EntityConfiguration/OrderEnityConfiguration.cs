using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class OrderEnityConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        //builder.Property(x => x.OrderId).HasConversion(x => x.ToGuid(), x => new Ulid(x));

    }
}
