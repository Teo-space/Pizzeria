﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pizzeria.Persistence.EntityConfiguration;

public class PaymentTypeEnityConfiguration : IEntityTypeConfiguration<PaymentType>
{
    public void Configure(EntityTypeBuilder<PaymentType> builder)
    {
        builder.HasKey(x => x.PaymentTypeId);

        builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
    }
}
