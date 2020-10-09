using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;

namespace Infrastructure.Configs
{
    public class TourDetailConfig : IEntityTypeConfiguration<TourDetail>
    {
        void IEntityTypeConfiguration<TourDetail>.Configure(EntityTypeBuilder<TourDetail> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasIndex(m => new { m.TourId, m.LocationId, m.Order}).IsUnique();
                
        }
    }
}