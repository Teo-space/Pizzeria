using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class DeliveryTypeEnityConfiguration : IEntityTypeConfiguration<DeliveryType>
{
    public void Configure(EntityTypeBuilder<DeliveryType> builder)
    {
        //builder.Property(x => x.DeliveryTypeId).HasConversion(x => x.ToGuid(), x => new Ulid(x));

    }
}
