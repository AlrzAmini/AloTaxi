﻿// <auto-generated />
using System;
using AloTaxi.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AloTaxi.Data.Migrations
{
    [DbContext(typeof(AloTaxiDbContext))]
    [Migration("20221020173417_AddIsDelete_AddSomeRelations")]
    partial class AddIsDelete_AddSomeRelations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Car.Car", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("CarNo")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<long?>("ColorId")
                        .HasColumnType("bigint");

                    b.Property<int>("CreateAtYear")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Car.CarColor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CarColors");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Car.DriverCar", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int?>("CarId")
                        .HasColumnType("int");

                    b.Property<long?>("CarId1")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DriverId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDriverOwnsCar")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CarId1");

                    b.HasIndex("DriverId");

                    b.ToTable("DriverCars");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Driver", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long?>("CarId")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecondPhoneNumber")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.HasKey("CustomerId");

                    b.HasIndex("CarId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Manager", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Address", b =>
                {
                    b.HasOne("AloTaxi.Domain.Entities.User.Customer", "Customer")
                        .WithMany("Address")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Car.Car", b =>
                {
                    b.HasOne("AloTaxi.Domain.Entities.User.Car.CarColor", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.Navigation("Color");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Car.DriverCar", b =>
                {
                    b.HasOne("AloTaxi.Domain.Entities.User.Car.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId1");

                    b.HasOne("AloTaxi.Domain.Entities.User.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.Navigation("Car");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Driver", b =>
                {
                    b.HasOne("AloTaxi.Domain.Entities.User.Car.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("AloTaxi.Domain.Entities.User.Customer", b =>
                {
                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
