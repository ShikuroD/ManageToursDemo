using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;
using System.Runtime.CompilerServices;

namespace Infrastructure.Configs
{
    public class TourConfig : IEntityTypeConfiguration<Tour>
    {
        void IEntityTypeConfiguration<Tour>.Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasOne<TourType>(m => m.TourType)
                .WithMany()
                .HasForeignKey(m => m.TourTypeId);

            builder.HasMany<Price>(m => m.Prices)
                .WithOne(t => t.Tour)
                .HasForeignKey(t => t.TourId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<TourDetail>(m => m.TourDetails)
                .WithOne(t => t.Tour)
                .HasForeignKey(t => t.TourId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasAnnotation("MinLength", 3);

            builder.Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(100)
                .HasAnnotation("MinLength", 3);
        }
    }
}
