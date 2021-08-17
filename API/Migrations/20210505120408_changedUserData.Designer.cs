﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210505120408_changedUserData")]
    partial class changedUserData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("VARCHAR(80)");

                    b.Property<string>("City")
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Country")
                        .HasColumnType("VARCHAR(60)");

                    b.Property<string>("Email")
                        .HasColumnType("VARCHAR(128)");

                    b.Property<string>("FirstName")
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("LastName")
                        .HasColumnType("VARCHAR(40)");

                    b.Property<string>("Phone")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("UserName")
                        .HasColumnType("VARCHAR(128)");

                    b.HasKey("Id");

                    b.ToTable("User", "Customer");
                });

            modelBuilder.Entity("API.Entities.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Make");
                });

            modelBuilder.Entity("API.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("FuelType")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("GearType")
                        .HasColumnType("VARCHAR(40)");

                    b.Property<int?>("MakeId")
                        .HasColumnType("int");

                    b.Property<int>("Mileage")
                        .HasColumnType("int");

                    b.Property<int?>("ModelId")
                        .HasColumnType("int");

                    b.Property<short>("ModelYear")
                        .HasColumnType("SMALLINT");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RegistrationNumber")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<string>("VehicleName")
                        .HasColumnType("VARCHAR(80)");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.HasIndex("ModelId");

                    b.ToTable("vehicle", "vehicles");
                });

            modelBuilder.Entity("API.Entities.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleModel");
                });

            modelBuilder.Entity("API.Entities.Vehicle", b =>
                {
                    b.HasOne("API.Entities.Make", "Make")
                        .WithMany("Vehicles")
                        .HasForeignKey("MakeId");

                    b.HasOne("API.Entities.VehicleModel", "Model")
                        .WithMany("Vehicle")
                        .HasForeignKey("ModelId");

                    b.Navigation("Make");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("API.Entities.Make", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("API.Entities.VehicleModel", b =>
                {
                    b.Navigation("Vehicle");
                });
#pragma warning restore 612, 618
        }
    }
}