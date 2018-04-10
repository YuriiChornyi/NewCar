﻿// <auto-generated />
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DAL.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20180409094931_Update")]
    partial class Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Body", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Bodies");
                });

            modelBuilder.Entity("DAL.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BodyID");

                    b.Property<string>("CarClass");

                    b.Property<int>("CarSalonID");

                    b.Property<int>("ColorID");

                    b.Property<int>("CompleteSetID");

                    b.Property<int>("EngineID");

                    b.Property<string>("ManufacturerName")
                        .IsRequired();

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<float>("Price");

                    b.Property<DateTime>("ProductionTime");

                    b.Property<int>("TransmitionID");

                    b.HasKey("ID");

                    b.HasIndex("BodyID");

                    b.HasIndex("CarSalonID");

                    b.HasIndex("ColorID");

                    b.HasIndex("CompleteSetID");

                    b.HasIndex("EngineID");

                    b.HasIndex("TransmitionID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("DAL.CarSalon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.Property<string>("Site");

                    b.HasKey("ID");

                    b.ToTable("CarSalons");
                });

            modelBuilder.Entity("DAL.Color", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColorCode")
                        .IsRequired();

                    b.Property<int>("ColorTypeID");

                    b.HasKey("ID");

                    b.HasIndex("ColorTypeID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("DAL.ColorType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("ColorTypes");
                });

            modelBuilder.Entity("DAL.CompleteSet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Photo");

                    b.HasKey("ID");

                    b.ToTable("CompleteSets");
                });

            modelBuilder.Entity("DAL.DriveWheels", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("DriveWheelses");
                });

            modelBuilder.Entity("DAL.Engine", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FuelType")
                        .IsRequired();

                    b.Property<float>("Value");

                    b.Property<float>("ValueByHundred");

                    b.HasKey("ID");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("DAL.GearBox", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("GearBoxes");
                });

            modelBuilder.Entity("DAL.Photo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarID");

                    b.Property<string>("PhotoURL")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("CarID");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("DAL.Transmition", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DriveWheelsID");

                    b.Property<int>("GearBoxID");

                    b.HasKey("ID");

                    b.HasIndex("DriveWheelsID");

                    b.HasIndex("GearBoxID");

                    b.ToTable("Transmitions");
                });

            modelBuilder.Entity("DAL.Car", b =>
                {
                    b.HasOne("DAL.Body", "Body")
                        .WithMany()
                        .HasForeignKey("BodyID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.CarSalon", "CarSalon")
                        .WithMany("CarCollection")
                        .HasForeignKey("CarSalonID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.CompleteSet", "CompleteSet")
                        .WithMany()
                        .HasForeignKey("CompleteSetID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Engine", "Engine")
                        .WithMany()
                        .HasForeignKey("EngineID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.Transmition", "Transmition")
                        .WithMany()
                        .HasForeignKey("TransmitionID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Color", b =>
                {
                    b.HasOne("DAL.ColorType", "ColorType")
                        .WithMany()
                        .HasForeignKey("ColorTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Photo", b =>
                {
                    b.HasOne("DAL.Car", "Car")
                        .WithMany("Photo")
                        .HasForeignKey("CarID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DAL.Transmition", b =>
                {
                    b.HasOne("DAL.DriveWheels", "DriveWheels")
                        .WithMany()
                        .HasForeignKey("DriveWheelsID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DAL.GearBox", "GearBox")
                        .WithMany()
                        .HasForeignKey("GearBoxID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
