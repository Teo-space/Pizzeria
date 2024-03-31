using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class DeliveryStatusEnityConfiguration : IEntityTypeConfiguration<DeliveryStatus>
{
    public void Configure(EntityTypeBuilder<DeliveryStatus> builder)
    {
        builder.HasKey(x => x.DeliveryStatusId);

        builder.Property(x => x.DeliveryStatusId).ValueGeneratedNever();

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
    }
}
