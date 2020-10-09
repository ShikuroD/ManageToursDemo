using AppCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configs
{
    public class JobConfig : IEntityTypeConfiguration<Job>
    {
        void IEntityTypeConfiguration<Job>.Configure(EntityTypeBuilder<Job> builder)
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
