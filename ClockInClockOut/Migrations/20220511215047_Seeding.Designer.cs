﻿// <auto-generated />
using System;
using ClockInClockOut.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClockInClockOut.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220511215047_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClockInClockOut.Data.Employee", b =>
                {
                    b.Property<int>("IdNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdNumber"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsClockedIN")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNumber");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            IdNumber = 1995,
                            FirstName = "Hensley",
                            IsClockedIN = false,
                            LastName = "Wint"
                        },
                        new
                        {
                            IdNumber = 2020,
                            FirstName = "Jason",
                            IsClockedIN = false,
                            LastName = "Choi"
                        },
                        new
                        {
                            IdNumber = 1234,
                            FirstName = "Max",
                            IsClockedIN = false,
                            LastName = "Samuel"
                        });
                });

            modelBuilder.Entity("ClockInClockOut.Data.Record", b =>
                {
                    b.Property<int>("ItemNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemNumber"), 1L, 1);

                    b.Property<DateTime>("ClockInTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClockOutTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdNumber")
                        .HasColumnType("int");

                    b.Property<double>("TotalHoursWorked")
                        .HasColumnType("float");

                    b.HasKey("ItemNumber");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            ItemNumber = 1,
                            ClockInTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClockOutTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeName = "Hensley Wint",
                            IdNumber = 1995,
                            TotalHoursWorked = 0.0
                        },
                        new
                        {
                            ItemNumber = 2,
                            ClockInTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClockOutTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeName = "Jason Choi",
                            IdNumber = 2020,
                            TotalHoursWorked = 0.0
                        },
                        new
                        {
                            ItemNumber = 3,
                            ClockInTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ClockOutTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeName = "Max Samuel",
                            IdNumber = 1234,
                            TotalHoursWorked = 0.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
