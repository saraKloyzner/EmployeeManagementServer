﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practicum.Data;

#nullable disable

namespace Practicum.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240409170505_creatDB")]
    partial class creatDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Practicum.Core.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MaleOrFemale")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartOfWorkDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Employees", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Rachel",
                            Identity = "123456789",
                            LastName = "Levi",
                            MaleOrFemale = false,
                            StartOfWorkDate = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Joseph",
                            Identity = "987654321",
                            LastName = "Cohen",
                            MaleOrFemale = true,
                            StartOfWorkDate = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1988, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Sarah",
                            Identity = "123123123",
                            LastName = "Johnson",
                            MaleOrFemale = false,
                            StartOfWorkDate = new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1995, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "John",
                            Identity = "456456456",
                            LastName = "Smith",
                            MaleOrFemale = true,
                            StartOfWorkDate = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1987, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Emily",
                            Identity = "789789789",
                            LastName = "Davis",
                            MaleOrFemale = false,
                            StartOfWorkDate = new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1992, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Michael",
                            Identity = "654654654",
                            LastName = "Martinez",
                            MaleOrFemale = true,
                            StartOfWorkDate = new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1986, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jessica",
                            Identity = "321321321",
                            LastName = "Brown",
                            MaleOrFemale = false,
                            StartOfWorkDate = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Daniel",
                            Identity = "987987987",
                            LastName = "Wilson",
                            MaleOrFemale = true,
                            StartOfWorkDate = new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true
                        });
                });

            modelBuilder.Entity("Practicum.Core.Models.EmployeePosition", b =>
                {
                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfStartingWork")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ManagerialPosition")
                        .HasColumnType("bit");

                    b.HasKey("PositionId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeePositions", (string)null);

                    b.HasData(
                        new
                        {
                            PositionId = 1,
                            EmployeeId = 1,
                            DateOfStartingWork = new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerialPosition = true
                        },
                        new
                        {
                            PositionId = 2,
                            EmployeeId = 2,
                            DateOfStartingWork = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerialPosition = false
                        },
                        new
                        {
                            PositionId = 1,
                            EmployeeId = 3,
                            DateOfStartingWork = new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerialPosition = true
                        },
                        new
                        {
                            PositionId = 2,
                            EmployeeId = 4,
                            DateOfStartingWork = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerialPosition = false
                        },
                        new
                        {
                            PositionId = 1,
                            EmployeeId = 5,
                            DateOfStartingWork = new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerialPosition = true
                        },
                        new
                        {
                            PositionId = 2,
                            EmployeeId = 6,
                            DateOfStartingWork = new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerialPosition = false
                        },
                        new
                        {
                            PositionId = 1,
                            EmployeeId = 7,
                            DateOfStartingWork = new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerialPosition = true
                        },
                        new
                        {
                            PositionId = 2,
                            EmployeeId = 8,
                            DateOfStartingWork = new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ManagerialPosition = false
                        });
                });

            modelBuilder.Entity("Practicum.Core.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Positions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Employee"
                        });
                });

            modelBuilder.Entity("Practicum.Core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "admin",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 2,
                            Name = "user",
                            Password = "654321"
                        });
                });

            modelBuilder.Entity("Practicum.Core.Models.EmployeePosition", b =>
                {
                    b.HasOne("Practicum.Core.Models.Employee", null)
                        .WithMany("EmployeePositions")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Practicum.Core.Models.Position", null)
                        .WithMany("EmployeePositions")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Practicum.Core.Models.Employee", b =>
                {
                    b.Navigation("EmployeePositions");
                });

            modelBuilder.Entity("Practicum.Core.Models.Position", b =>
                {
                    b.Navigation("EmployeePositions");
                });
#pragma warning restore 612, 618
        }
    }
}
