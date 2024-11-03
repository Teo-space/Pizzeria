using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class OrderEnityConfiguration : IEntityTypeConfiguration<Order>
{
    int order = 0;
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x => x.OrderId);

        builder.Property(x => x.OrderId)
            .HasColumnOrder(order++)
            .HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.Status)
            .HasColumnOrder(order++)
            .IsRequired()
            .IsConcurrencyToken();

        builder.ComplexProperty(x => x.Date, date =>
        {
            date.IsRequired();
            date.Property(x => x.Created).HasColumnOrder(order++).IsRequired().HasColumnType("datetime");
            date.Property(x => x.Modified).HasColumnOrder(order++).IsRequired().HasColumnType("datetime");
            date.Property(x => x.Ready).HasColumnOrder(order++).IsRequired().HasColumnType("datetime");
        });

        builder.ComplexProperty(x => x.Client, client =>
        {
            client.IsRequired();

            client.Property(x => x.Phone).HasColumnOrder(order++).IsRequired();
            client.Property(x => x.Email).HasColumnOrder(order++);
            client.Property(x => x.Name).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
            client.Property(x => x.SurName).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
            client.Property(x => x.Patronymic).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
        });

        builder.ComplexProperty(x => x.Delivery, delivery =>
        {
            delivery.IsRequired();

            delivery.Property(x => x.TypeId).HasColumnOrder(order++).IsRequired();
            delivery.Property(x => x.Status).HasColumnOrder(order++).IsRequired();

            delivery.Property(x => x.Start).HasColumnOrder(order++).IsRequired().HasColumnType("datetime");
            delivery.Property(x => x.End).HasColumnOrder(order++).IsRequired().HasColumnType("datetime");

            delivery.ComplexProperty(x => x.Address, address =>
            {
                address.IsRequired();

                address.Property(x => x.City).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
                address.Property(x => x.Street).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
                address.Property(x => x.House).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
                address.Property(x => x.Apartment).HasColumnOrder(order++).IsRequired().HasMaxLength(100);

                address.Property(x => x.Entrance).HasColumnOrder(order++).HasMaxLength(100);
                address.Property(x => x.Floor).HasColumnOrder(order++).HasMaxLength(100);
            });
        });

        builder.ComplexProperty(x => x.Payment, payment =>
        {
            payment.IsRequired();

            payment.Property(x => x.Type).HasColumnOrder(order++).IsRequired();
            payment.Property(x => x.Sum).HasColumnOrder(order++).IsRequired();
            payment.Property(x => x.Payed).HasColumnOrder(order++).IsRequired().HasColumnType("datetime");
            payment.Property(x => x.IsPayed).HasColumnOrder(order++).IsRequired().HasPrecision(15, 6);
        });

        builder.ComplexProperty(x => x.Shop, shop =>
        {
            shop.IsRequired();

            shop.Property(x => x.ShopId).HasColumnOrder(order++).IsRequired();
            shop.Property(x => x.Name).HasColumnOrder(order++).IsRequired();

            shop.ComplexProperty(x => x.Address, address =>
            {
                address.IsRequired();

                address.Property(x => x.City).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
                address.Property(x => x.Street).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
                address.Property(x => x.House).HasColumnOrder(order++).IsRequired().HasMaxLength(100);
                address.Property(x => x.Building).HasColumnOrder(order++).IsRequired().HasMaxLength(100);

                address.Property(x => x.Office).HasColumnOrder(order++).HasMaxLength(100);
            });
        });
    }
}
