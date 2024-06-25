﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Models;

public partial class HotelReservationSystemContext : DbContext
{
    public HotelReservationSystemContext(DbContextOptions<HotelReservationSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CheckIn> CheckIns { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CheckIn>(entity =>
        {
            entity.Property(e => e.CheckInId).HasColumnName("CheckInID");
            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(25);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.Amount).HasColumnType("money");
            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.Property(e => e.ReservationId).HasColumnName("ReservationID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasMaxLength(25);
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.Property(e => e.RoomId).HasColumnName("RoomID");
            entity.Property(e => e.AvailabilityStatus)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.RoomType)
                .IsRequired()
                .HasMaxLength(25);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}