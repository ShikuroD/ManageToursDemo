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

        }


        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<TourDetail> TourDetails { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Price> Prices { get; set; }
    }
}
