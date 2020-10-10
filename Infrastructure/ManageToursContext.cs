using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AppCore.Models;
using Infrastructure.Configs;

namespace Infrastructure
{
    public class ManageToursContext : DbContext
    {
        public ManageToursContext(DbContextOptions<ManageToursContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new TourConfig());
            builder.ApplyConfiguration(new TourTypeConfig());
            builder.ApplyConfiguration(new TourDetailConfig());
            builder.ApplyConfiguration(new PriceConfig());
            builder.ApplyConfiguration(new LocationConfig());
            builder.ApplyConfiguration(new CustomerConfig());
            builder.ApplyConfiguration(new GroupDetailConfig());
            builder.ApplyConfiguration(new JobConfig());
            builder.ApplyConfiguration(new EmployeeConfig());
            builder.ApplyConfiguration(new AttendantConfig());
            builder.ApplyConfiguration(new GroupConfig());
            builder.ApplyConfiguration(new CostTypeConfig());
            builder.ApplyConfiguration(new CostConfig());


        }


        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<TourDetail> TourDetails { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Price> Prices { get; set; }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendant> Attendants { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<GroupDetail> GroupDetails { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<CostType> CostTypes { get; set; }
        public DbSet<Cost> Costs { get; set; }

    }
}
