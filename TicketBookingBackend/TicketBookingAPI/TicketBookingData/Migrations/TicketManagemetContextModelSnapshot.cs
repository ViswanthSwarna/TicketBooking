﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketBooking.Data;

#nullable disable

namespace TicketBookingData.Migrations
{
    [DbContext(typeof(TicketManagemetContext))]
    partial class TicketManagemetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketBooking.Domain.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DestinationCityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("SourceCityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DestinationCityId");

                    b.HasIndex("SourceCityId");

                    b.ToTable("Bus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusName = "Rajdhani",
                            DestinationCityId = 2,
                            EndDateTime = new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SourceCityId = 1,
                            StartDateTime = new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Delux"
                        },
                        new
                        {
                            Id = 2,
                            BusName = "Rajdhani001",
                            DestinationCityId = 3,
                            EndDateTime = new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SourceCityId = 2,
                            StartDateTime = new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "SuperDelux"
                        },
                        new
                        {
                            Id = 3,
                            BusName = "Rajdhani002",
                            DestinationCityId = 4,
                            EndDateTime = new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SourceCityId = 3,
                            StartDateTime = new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Delux"
                        },
                        new
                        {
                            Id = 4,
                            BusName = "Rajdhani003",
                            DestinationCityId = 5,
                            EndDateTime = new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SourceCityId = 4,
                            StartDateTime = new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "SuperDelux"
                        },
                        new
                        {
                            Id = 5,
                            BusName = "Rajdhani004",
                            DestinationCityId = 6,
                            EndDateTime = new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SourceCityId = 5,
                            StartDateTime = new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Normal"
                        },
                        new
                        {
                            Id = 6,
                            BusName = "Rajdhani005",
                            DestinationCityId = 7,
                            EndDateTime = new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SourceCityId = 6,
                            StartDateTime = new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "DeluxSleeper"
                        });
                });

            modelBuilder.Entity("TicketBooking.Domain.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Dhule"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bangalore"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mumbai"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Nashik"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pune"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Delhi"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Nagpur"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Kanpur"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Satara"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Kolhapur"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Vijaywada"
                        });
                });

            modelBuilder.Entity("TicketBooking.Domain.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BusId")
                        .HasColumnType("int");

                    b.Property<double>("Fare")
                        .HasColumnType("float");

                    b.Property<bool>("IsPaymentDone")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("UserId");

                    b.ToTable("Ticket");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusId = 1,
                            Fare = 200.0,
                            IsPaymentDone = true,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BusId = 2,
                            Fare = 200.0,
                            IsPaymentDone = false,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            BusId = 3,
                            Fare = 200.0,
                            IsPaymentDone = true,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            BusId = 4,
                            Fare = 200.0,
                            IsPaymentDone = false,
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            BusId = 1,
                            Fare = 200.0,
                            IsPaymentDone = true,
                            UserId = 3
                        },
                        new
                        {
                            Id = 6,
                            BusId = 3,
                            Fare = 200.0,
                            IsPaymentDone = false,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TicketBooking.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGuestUser")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLoggedIn")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "R.Salunkhe@devon.nl",
                            FullName = "Rakesh Salunkhe",
                            IsAdmin = true,
                            IsGuestUser = false,
                            IsLoggedIn = false,
                            Password = "123123",
                            PhoneNumber = "860019111"
                        },
                        new
                        {
                            Id = 2,
                            Email = "M.Mummmm@devon.nl",
                            FullName = "M M M",
                            IsAdmin = false,
                            IsGuestUser = false,
                            IsLoggedIn = false,
                            Password = "123123",
                            PhoneNumber = "860019111"
                        },
                        new
                        {
                            Id = 3,
                            Email = "C.cccccc@devon.nl",
                            FullName = "C C C",
                            IsAdmin = true,
                            IsGuestUser = false,
                            IsLoggedIn = false,
                            Password = "123123",
                            PhoneNumber = "860019111"
                        });
                });

            modelBuilder.Entity("TicketBooking.Domain.Bus", b =>
                {
                    b.HasOne("TicketBooking.Domain.City", "DestinationCity")
                        .WithMany()
                        .HasForeignKey("DestinationCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBooking.Domain.City", "SourceCity")
                        .WithMany()
                        .HasForeignKey("SourceCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DestinationCity");

                    b.Navigation("SourceCity");
                });

            modelBuilder.Entity("TicketBooking.Domain.Ticket", b =>
                {
                    b.HasOne("TicketBooking.Domain.Bus", "Bus")
                        .WithMany()
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBooking.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
