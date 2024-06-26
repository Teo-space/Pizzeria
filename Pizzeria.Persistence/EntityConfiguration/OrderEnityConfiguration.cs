﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class OrderEnityConfiguration : IEntityTypeConfiguration<Order>
{
    int o = 0;
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x => x.OrderId);
        
        builder.Property(x => x.OrderId)
            .HasColumnOrder(o++)
            .HasConversion(x => x.ToGuid(), x => new Ulid(x));

        builder.Property(x => x.Status)
            .HasColumnOrder(o++)
            .IsRequired()
            .IsConcurrencyToken();

        builder.ComplexProperty(x => x.Date, date =>
        {
            date.IsRequired();
            date.Property(x => x.Created).HasColumnOrder(o++).IsRequired().HasColumnType("datetime");
            date.Property(x => x.Modified).HasColumnOrder(o++).IsRequired().HasColumnType("datetime");
            date.Property(x => x.Ready).HasColumnOrder(o++).IsRequired().HasColumnType("datetime");
        });

        builder.ComplexProperty(x => x.Client, client =>
        {
            client.IsRequired();

            client.Property(x => x.Phone).HasColumnOrder(o++).IsRequired();
            client.Property(x => x.Email).HasColumnOrder(o++);
            client.Property(x => x.Name).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
            client.Property(x => x.SurName).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
            client.Property(x => x.Patronymic).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
        });

        builder.ComplexProperty(x => x.Delivery, delivery =>
        {
            delivery.IsRequired();

            delivery.Property(x => x.TypeId).HasColumnOrder(o++).IsRequired();
            delivery.Property(x => x.Status).HasColumnOrder(o++).IsRequired();

            delivery.Property(x => x.Start).HasColumnOrder(o++).IsRequired().HasColumnType("datetime");
            delivery.Property(x => x.End).HasColumnOrder(o++).IsRequired().HasColumnType("datetime");

            delivery.ComplexProperty(x => x.Address, address =>
            {
                address.IsRequired();

                address.Property(x => x.City).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
                address.Property(x => x.Street).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
                address.Property(x => x.House).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
                address.Property(x => x.Apartment).HasColumnOrder(o++).IsRequired().HasMaxLength(100);

                address.Property(x => x.Entrance).HasColumnOrder(o++).HasMaxLength(100);
                address.Property(x => x.Floor).HasColumnOrder(o++).HasMaxLength(100);
            });
        });

        builder.ComplexProperty(x => x.Payment, payment =>
        {
            payment.IsRequired();

            payment.Property(x => x.Type).HasColumnOrder(o++).IsRequired();
            payment.Property(x => x.Sum).HasColumnOrder(o++).IsRequired();
            payment.Property(x => x.Payed).HasColumnOrder(o++).IsRequired().HasColumnType("datetime");
            payment.Property(x => x.IsPayed).HasColumnOrder(o++).IsRequired().HasPrecision(15, 6);
        });

        builder.ComplexProperty(x => x.Shop, shop =>
        {
            shop.IsRequired();

            shop.Property(x => x.ShopId).HasColumnOrder(o++).IsRequired();
            shop.Property(x => x.Name).HasColumnOrder(o++).IsRequired();

            shop.ComplexProperty(x => x.Address, address =>
            {
                address.IsRequired();

                address.Property(x => x.City).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
                address.Property(x => x.Street).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
                address.Property(x => x.House).HasColumnOrder(o++).IsRequired().HasMaxLength(100);
                address.Property(x => x.Building).HasColumnOrder(o++).IsRequired().HasMaxLength(100);

                address.Property(x => x.Office).HasColumnOrder(o++).HasMaxLength(100);
            });
        });
    }
}
