﻿// <auto-generated />
using System;
using CarRental.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRental.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarRental.Models.Cars", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RentalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            Brand = "Toyota",
                            ImageUrl = "vios.jpg",
                            Model = "Vios",
                            RentalPrice = 2000m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 2,
                            Brand = "Honda",
                            ImageUrl = "city.jpg",
                            Model = "City",
                            RentalPrice = 2200m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 3,
                            Brand = "Mitsubishi",
                            ImageUrl = "mirage.jpg",
                            Model = "Mirage G4",
                            RentalPrice = 2000m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 4,
                            Brand = "Nissan",
                            ImageUrl = "almera.jpg",
                            Model = "Almera",
                            RentalPrice = 2300m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 5,
                            Brand = "Ford",
                            ImageUrl = "ecosport.jpg",
                            Model = "EcoSport",
                            RentalPrice = 2800m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 6,
                            Brand = "Suzuki",
                            ImageUrl = "dzire.jpg",
                            Model = "Dzire",
                            RentalPrice = 2000m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 7,
                            Brand = "Hyundai",
                            ImageUrl = "accent.jpg",
                            Model = "Accent",
                            RentalPrice = 2500m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 8,
                            Brand = "Kia",
                            ImageUrl = "soluto.jpg",
                            Model = "Soluto",
                            RentalPrice = 2300m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 9,
                            Brand = "Chevrolet",
                            ImageUrl = "spark.jpg",
                            Model = "Spark",
                            RentalPrice = 2200m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 10,
                            Brand = "Mazda",
                            ImageUrl = "sedan.jpg",
                            Model = "2 Sedan",
                            RentalPrice = 2400m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 11,
                            Brand = "Subaru",
                            ImageUrl = "xv.jpg",
                            Model = "XV",
                            RentalPrice = 3200m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 12,
                            Brand = "Toyota",
                            ImageUrl = "avanza.jpg",
                            Model = "Avanza",
                            RentalPrice = 3500m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 13,
                            Brand = "Mitsubishi",
                            ImageUrl = "xpander.jpg",
                            Model = "Xpander",
                            RentalPrice = 3800m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 14,
                            Brand = "Suzuki",
                            ImageUrl = "ertiga.jpg",
                            Model = "Ertiga",
                            RentalPrice = 3200m,
                            Status = "Available"
                        },
                        new
                        {
                            CarId = 15,
                            Brand = "Nissan",
                            ImageUrl = "livina.jpg",
                            Model = "Livina",
                            RentalPrice = 3500m,
                            Status = "Available"
                        });
                });

            modelBuilder.Entity("CarRental.Models.RentalRequest", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<decimal>("EstimatedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RenterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestId");

                    b.HasIndex("CarId");

                    b.HasIndex("RenterId");

                    b.ToTable("RentalRequests");
                });

            modelBuilder.Entity("CarRental.Models.Rentals", b =>
                {
                    b.Property<int>("RentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentalId"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentalDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RenterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RentalId");

                    b.HasIndex("CarId");

                    b.HasIndex("RenterId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("CarRental.Models.Renters", b =>
                {
                    b.Property<int>("RenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RenterId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserAccountId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RenterId");

                    b.HasIndex("UserAccountId");

                    b.ToTable("Renters");
                });

            modelBuilder.Entity("CarRental.Models.UserAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("CarRental.Models.RentalRequest", b =>
                {
                    b.HasOne("CarRental.Models.Cars", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental.Models.Renters", "Renters")
                        .WithMany()
                        .HasForeignKey("RenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Renters");
                });

            modelBuilder.Entity("CarRental.Models.Rentals", b =>
                {
                    b.HasOne("CarRental.Models.Cars", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental.Models.Renters", "Renters")
                        .WithMany()
                        .HasForeignKey("RenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Renters");
                });

            modelBuilder.Entity("CarRental.Models.Renters", b =>
                {
                    b.HasOne("CarRental.Models.UserAccount", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
