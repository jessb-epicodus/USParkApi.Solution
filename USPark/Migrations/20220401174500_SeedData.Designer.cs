﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using USPark.Models;

namespace USPark.Migrations
{
    [DbContext(typeof(USParkContext))]
    [Migration("20220401174500_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("USPark.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("ADA")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Activities")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Amenities")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ManagedBy")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("State")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            ADA = true,
                            Activities = "lots",
                            Amenities = "lots",
                            City = "Cody",
                            ManagedBy = "National Park Service",
                            Name = "Yellowstone",
                            State = "Wyoming"
                        },
                        new
                        {
                            ParkId = 2,
                            ADA = true,
                            Activities = "lots",
                            Amenities = "lots",
                            City = "Gardiner",
                            ManagedBy = "National Park Service",
                            Name = "Yellowstone",
                            State = "Montana"
                        },
                        new
                        {
                            ParkId = 4,
                            ADA = true,
                            Activities = "hiking, camping",
                            Amenities = "lots",
                            City = "Jackson",
                            ManagedBy = "National Park Service",
                            Name = "Grand Teton",
                            State = "Wyoming"
                        },
                        new
                        {
                            ParkId = 5,
                            ADA = true,
                            Activities = "fishing",
                            Amenities = "restrooms",
                            City = "Molalla",
                            ManagedBy = "Bureau of Land Management",
                            Name = "Molalla River Recreation Area",
                            State = "Oregon"
                        },
                        new
                        {
                            ParkId = 6,
                            ADA = true,
                            Activities = "trail running",
                            Amenities = "",
                            City = "Portland",
                            ManagedBy = "Portland Parks and Recreation",
                            Name = "Forest Park",
                            State = "Oregon"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
