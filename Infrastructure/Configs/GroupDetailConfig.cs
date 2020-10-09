using AppCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configs
{
    public class GroupDetailConfig : IEntityTypeConfiguration<GroupDetail>
    {
        void IEntityTypeConfiguration<GroupDetail>.Configure(EntityTypeBuilder<GroupDetail> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasIndex(m => new { m.GroupId, m.CustomerId }).IsUnique();

        }
    }
}
