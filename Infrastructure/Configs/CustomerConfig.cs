﻿using AppCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configs
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        void IEntityTypeConfiguration<Customer>.Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd();

            builder.HasMany<GroupDetail>()
                .WithOne(t => t.Customer)
                .HasForeignKey(t => t.CustomerId);

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(30)
                .HasAnnotation("MinLength", 3);

            builder.Property(m => m.IdentityCode)
                .IsRequired()
                .HasMaxLength(10)
                .HasAnnotation("MinLength", 10);
            builder.HasIndex(m => m.IdentityCode).IsUnique();

            builder.Property(m => m.PhoneNumber)
                .IsRequired()
                .HasMaxLength(10)
                .HasAnnotation("MinLength", 10);


            builder.Property(m => m.Address)
                .HasMaxLength(60)
                .HasAnnotation("MinLength", 3);
        }
    }
}

