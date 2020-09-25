using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace Infrastructure.Configs
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        void IEntityTypeConfiguration<Location>.Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasMany<TourDetail>(m => m.TourDetails)
                .WithOne(t => t.Location)
                .HasForeignKey(t => t.LocationId);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasAnnotation("MinLength", 3);
        }
    }
}
