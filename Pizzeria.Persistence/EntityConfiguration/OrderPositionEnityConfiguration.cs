using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class OrderPositionEnityConfiguration : IEntityTypeConfiguration<OrderPosition>
{
    public void Configure(EntityTypeBuilder<OrderPosition> builder)
    {
        builder.HasKey(x => x.OrderPositionId);
        builder.HasIndex(x => x.OrderId);
        builder.HasIndex(x => new
        {
            x.OrderId,
            x.ProductId,
        }).IsUnique();

        builder.Property(x => x.OrderPositionId).IsRequired()
            .HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.OrderId).IsRequired()
            .HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.ProductId).IsRequired()
            .HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.ProductTypeId).IsRequired()
            .HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.Quanity).IsRequired();
        builder.Property(x => x.Price).IsRequired().HasPrecision(15, 6);
        builder.Ignore(x => x.Sum);
        builder.Property(x => x.IsReady).IsRequired();
        builder.Property(x => x.NeedCooking).IsRequired();

    }
}
