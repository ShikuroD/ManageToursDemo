using AppCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configs
{
    public class CostConfig : IEntityTypeConfiguration<Cost>
    {
        void IEntityTypeConfiguration<Cost>.Configure(EntityTypeBuilder<Cost> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasOne<CostType>(m => m.CostType)
                .WithMany()
                .HasForeignKey(m => m.CostTypeId);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasAnnotation("MinLength", 3);
        }
    }
}
