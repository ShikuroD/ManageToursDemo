using AppCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configs
{
    public class GroupConfig : IEntityTypeConfiguration<Group>
    {
        void IEntityTypeConfiguration<Group>.Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasMany<Cost>(m => m.Costs)
                .WithOne(t => t.Group)
                .HasForeignKey(t => t.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<GroupDetail>(m => m.GroupDetails)
                .WithOne(t => t.Group)
                .HasForeignKey(t => t.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany<Attendant>(m => m.Attendants)
                .WithOne(t => t.Group)
                .HasForeignKey(t => t.GroupId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasAnnotation("MinLength", 3);
        }
    }
}
