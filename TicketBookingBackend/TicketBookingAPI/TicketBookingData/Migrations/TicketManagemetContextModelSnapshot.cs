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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

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

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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
                            UserId = "3a7dca8c-4a86-45be-8e63-d505f7e2d13b"
                        },
                        new
                        {
                            Id = 2,
                            BusId = 2,
                            Fare = 200.0,
                            IsPaymentDone = false,
                            UserId = "dbf57150-2989-4771-ab6d-08c487470555"
                        },
                        new
                        {
                            Id = 3,
                            BusId = 3,
                            Fare = 200.0,
                            IsPaymentDone = true,
                            UserId = "a99eaff9-a21f-49f7-ae35-e8479b3d4d9e"
                        },
                        new
                        {
                            Id = 4,
                            BusId = 4,
                            Fare = 200.0,
                            IsPaymentDone = false,
                            UserId = "3a7dca8c-4a86-45be-8e63-d505f7e2d13b"
                        },
                        new
                        {
                            Id = 5,
                            BusId = 1,
                            Fare = 200.0,
                            IsPaymentDone = true,
                            UserId = "a99eaff9-a21f-49f7-ae35-e8479b3d4d9e"
                        },
                        new
                        {
                            Id = 6,
                            BusId = 3,
                            Fare = 200.0,
                            IsPaymentDone = false,
                            UserId = "dbf57150-2989-4771-ab6d-08c487470555"
                        });
                });

            modelBuilder.Entity("TicketBooking.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGuestUser")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "3a7dca8c-4a86-45be-8e63-d505f7e2d13b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1fe6bb6f-35cc-4cc1-9a53-8f34173f2323",
                            Email = "R.Salunkhe@devon.nl",
                            EmailConfirmed = false,
                            IsGuestUser = false,
                            LockoutEnabled = false,
                            PasswordHash = "Abc@123",
                            PhoneNumber = "860019111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3f34e65f-6c38-41b6-82bf-766feaf46754",
                            TwoFactorEnabled = false,
                            UserName = "Rakesh Salunkhe"
                        },
                        new
                        {
                            Id = "dbf57150-2989-4771-ab6d-08c487470555",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ac2212df-ba96-4286-8846-6028d29f7b9f",
                            Email = "M.Mummmm@devon.nl",
                            EmailConfirmed = false,
                            IsGuestUser = false,
                            LockoutEnabled = false,
                            PasswordHash = "Abc@123",
                            PhoneNumber = "860019111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "02c96b82-bbb7-4f14-a6ca-696c294622b2",
                            TwoFactorEnabled = false,
                            UserName = "M M M"
                        },
                        new
                        {
                            Id = "a99eaff9-a21f-49f7-ae35-e8479b3d4d9e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4fa32be6-c010-45f8-9dc9-198409594c32",
                            Email = "C.cccccc@devon.nl",
                            EmailConfirmed = false,
                            IsGuestUser = false,
                            LockoutEnabled = false,
                            PasswordHash = "Abc@123",
                            PhoneNumber = "860019111",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7ddb8f1e-b50d-482e-a809-e8a902f23e0b",
                            TwoFactorEnabled = false,
                            UserName = "C C C"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TicketBooking.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TicketBooking.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketBooking.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TicketBooking.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
