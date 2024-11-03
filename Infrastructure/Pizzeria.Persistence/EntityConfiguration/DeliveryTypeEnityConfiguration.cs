using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class DeliveryTypeEnityConfiguration : IEntityTypeConfiguration<DeliveryType>
{
    public void Configure(EntityTypeBuilder<DeliveryType> builder)
    {
        builder.HasKey(x => x.DeliveryTypeId);

        builder.Property(x => x.DeliveryTypeId).ValueGeneratedNever();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

        builder.Property(x => x.Price).IsRequired().HasPrecision(15, 6);


    }
}
