using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace Infrastructure.Configs
{
    public class TourTypeConfig : IEntityTypeConfiguration<TourType>
    {
        void IEntityTypeConfiguration<TourType>.Configure(EntityTypeBuilder<TourType> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(30)
                .HasAnnotation("MinLength", 3);
        }
    }
}