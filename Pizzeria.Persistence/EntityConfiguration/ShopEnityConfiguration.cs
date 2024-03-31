using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class ShopEnityConfiguration : IEntityTypeConfiguration<Shop>
{
    public void Configure(EntityTypeBuilder<Shop> builder)
    {
        builder.HasKey(x => x.ShopId);
        builder.HasIndex(x => x.Name).IsUnique();

        builder.Property(x => x.ShopId).ValueGeneratedNever();
        builder.Property(x => x.Name).HasMaxLength(100);


        builder.ComplexProperty(x => x.Address, address =>
        {
            address.IsRequired();

            address.Property(x => x.City).IsRequired().HasMaxLength(100);
            address.Property(x => x.Street).IsRequired().HasMaxLength(100);
            address.Property(x => x.House).IsRequired().HasMaxLength(20);
            address.Property(x => x.Building).IsRequired().HasMaxLength(20);

            address.Property(x => x.Office).HasMaxLength(20);
        });
    }
}
