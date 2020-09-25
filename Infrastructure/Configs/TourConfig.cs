using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace Infrastructure.Configs
{
    public class TourConfig : IEntityTypeConfiguration<Tour>
    {
        void IEntityTypeConfiguration<Tour>.Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasMany<Price>(m => m.Prices)
                .WithOne(t => t.Tour)
                .HasForeignKey(t => t.TourId);

            builder.HasMany<TourDetail>(m => m.TourDetails)
                .WithOne(t => t.Tour)
                .HasForeignKey(t => t.TourId);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasAnnotation("MinLength", 3);
        }
    }
}
