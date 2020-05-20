﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF
{
    public class VSFlightContext : DbContext
    {
        public DbSet<Flight> FlightSet { get; set; }
        public DbSet<Passenger> PassengerSet { get; set; }
        public DbSet<Booking> BookingSet { get; set; }

        public static string ConnectionString { get; set; } = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=.\BerclazFardel_VSFly\VSFly_BerclazFardel_WebAPI\EF\VSFlyDB.mdf;Integrated Security=True";

        // Constructor
        public VSFlightContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConnectionString);

            // Convinient, flexible BUT DANGEROUS FOR PERFORMANCE
            builder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Composed
            builder.Entity<Booking>().HasKey(x => new { x.FlightNo, x.PassengerID });

            // Mapping many to many relationship
            builder.Entity<Booking>()
                .HasOne(x => x.Flight)
                .WithMany(x => x.BookingSet)
                .HasForeignKey(x => x.FlightNo)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Booking>()
                .HasOne(x => x.Passenger)
                .WithMany(x => x.BookingSet)
                .HasForeignKey(x => x.PassengerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
