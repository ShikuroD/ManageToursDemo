using AppCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configs
{
    public class AttendantConfig : IEntityTypeConfiguration<Attendant>
    {
        void IEntityTypeConfiguration<Attendant>.Configure(EntityTypeBuilder<Attendant> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasIndex(m => new { m.GroupId, m.EmployeeId}).IsUnique();

        }
    }
}
