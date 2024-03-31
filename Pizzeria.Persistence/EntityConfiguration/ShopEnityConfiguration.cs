using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Pizzeria.Persistence.EntityConfiguration;

public class ShopEnityConfiguration : IEntityTypeConfiguration<Shop>
{
    public void Configure(EntityTypeBuilder<Shop> builder)
    {
        builder.HasKey(x => x.ShopId);
        builder.HasIndex(x => x.Name).IsUnique();

        builder.Property(x => x.ShopId).ValueGeneratedNever();
        builder.Property(x => x.Name).HasMaxLength(100);

        /*
        builder.ComplexProperty(x => x.Address, complexType =>
        {
            //complexType.IsRequired();

            complexType.Property(x => x.City).IsRequired().HasMaxLength(100);
            complexType.Property(x => x.Street).IsRequired().HasMaxLength(100);
            complexType.Property(x => x.House).IsRequired().HasMaxLength(20);
            complexType.Property(x => x.Building).IsRequired().HasMaxLength(20);

            complexType.Property(x => x.Office).IsRequired(false).HasMaxLength(20);
        });
        */

        //Address
        builder.OwnsOne(x => x.Address, owned =>
        {
            owned.Property(x => x.City).IsRequired().HasMaxLength(100);
            owned.Property(x => x.Street).IsRequired().HasMaxLength(100);
            owned.Property(x => x.House).IsRequired().HasMaxLength(20);
            owned.Property(x => x.Building).IsRequired().HasMaxLength(20);

            owned.Property(x => x.Office).IsRequired(false).HasMaxLength(20);
        });


    }
}
