using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace Infrastructure.Configs
{
    public class PriceConfig : IEntityTypeConfiguration<Price>
    {
        void IEntityTypeConfiguration<Price>.Configure(EntityTypeBuilder<Price> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.Property(m => m.Value)
                .HasColumnType("decimal(18,2)");
        }
    }
}