﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RapidPay.Data;

#nullable disable

namespace RapidPay.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RapidPay.Domain.Authentication.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f263ea05-c85c-41e0-b59b-ea6a4a47cd42",
                            Email = "demo@rapidpay.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMO@RAPIDPAY.COM",
                            NormalizedUserName = "DEMO@RAPIDPAY.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEN1hW8BBJmBWjD6+1jEDshXy+hd30gXW7LDjgM4UroFGaKk7hgJe8yAAOpcSix1v9Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "NjM4NTI0MzAxOTkzMjM2MDQ1",
                            TwoFactorEnabled = false,
                            UserName = "demo@rapidpay.com"
                        });
                });

            modelBuilder.Entity("RapidPay.Domain.Authentication.Models.ApplicationUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationUserId")
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = 1,
                            ClaimType = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier",
                            ClaimValue = "1",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = 1,
                            ClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                            ClaimValue = "Manager",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            ApplicationUserId = 1,
                            ClaimType = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role",
                            ClaimValue = "Client",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("RapidPay.Domain.Payment.Models.CreditCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ApplicationUserId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedIPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("int");

                    b.Property<int>("CreditCardBrand")
                        .HasColumnType("int");

                    b.Property<string>("CreditCardExpiration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedIPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedUser")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("CreditCard", "payment");
                });

            modelBuilder.Entity("RapidPay.Domain.Store.Models.Fee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Current")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Past")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReferenceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Fee", "payment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Current = 1m,
                            Past = 1m,
                            ReferenceDate = new DateTime(2024, 5, 27, 18, 9, 59, 434, DateTimeKind.Utc).AddTicks(4451)
                        });
                });

            modelBuilder.Entity("RapidPay.Domain.Store.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedIPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModifiedIPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedUser")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Product", "payment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Active = true,
                            CreatedIPAddress = "0.0.0.1",
                            CreatedOnUtc = new DateTime(2024, 5, 27, 18, 9, 59, 433, DateTimeKind.Utc).AddTicks(3002),
                            CreatedUser = 1,
                            Description = "Levono Laptop",
                            ModifiedIPAddress = "0.0.0.1",
                            ModifiedOnUtc = new DateTime(2024, 5, 27, 18, 9, 59, 433, DateTimeKind.Utc).AddTicks(3002),
                            ModifiedUser = 1,
                            Name = "Lenovo Laptop",
                            Price = 1799m
                        },
                        new
                        {
                            Id = 2,
                            Active = true,
                            CreatedIPAddress = "0.0.0.1",
                            CreatedOnUtc = new DateTime(2024, 5, 27, 18, 9, 59, 433, DateTimeKind.Utc).AddTicks(3002),
                            CreatedUser = 1,
                            Description = "Macbook",
                            ModifiedIPAddress = "0.0.0.1",
                            ModifiedOnUtc = new DateTime(2024, 5, 27, 18, 9, 59, 433, DateTimeKind.Utc).AddTicks(3002),
                            ModifiedUser = 1,
                            Name = "Macbook",
                            Price = 3199m
                        },
                        new
                        {
                            Id = 3,
                            Active = true,
                            CreatedIPAddress = "0.0.0.1",
                            CreatedOnUtc = new DateTime(2024, 5, 27, 18, 9, 59, 433, DateTimeKind.Utc).AddTicks(3002),
                            CreatedUser = 1,
                            Description = "iPhone",
                            ModifiedIPAddress = "0.0.0.1",
                            ModifiedOnUtc = new DateTime(2024, 5, 27, 18, 9, 59, 433, DateTimeKind.Utc).AddTicks(3002),
                            ModifiedUser = 1,
                            Name = "iPhone",
                            Price = 999m
                        },
                        new
                        {
                            Id = 4,
                            Active = true,
                            CreatedIPAddress = "0.0.0.1",
                            CreatedOnUtc = new DateTime(2024, 5, 27, 18, 9, 59, 433, DateTimeKind.Utc).AddTicks(3002),
                            CreatedUser = 1,
                            Description = "iPhone charger",
                            ModifiedIPAddress = "0.0.0.1",
                            ModifiedOnUtc = new DateTime(2024, 5, 27, 18, 9, 59, 433, DateTimeKind.Utc).AddTicks(3002),
                            ModifiedUser = 1,
                            Name = "iPhone charger",
                            Price = 49m
                        });
                });

            modelBuilder.Entity("RapidPay.Domain.Store.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedIPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedUser")
                        .HasColumnType("int");

                    b.Property<int>("CreditCardId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ModifiedIPAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOnUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModifiedUser")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CreditCardId");

                    b.HasIndex("ProductId");

                    b.ToTable("Purchase", "payment");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("RapidPay.Domain.Authentication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RapidPay.Domain.Authentication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("RapidPay.Domain.Authentication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RapidPay.Domain.Authentication.Models.ApplicationUserClaim", b =>
                {
                    b.HasOne("RapidPay.Domain.Authentication.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("UserClaims")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("RapidPay.Domain.Authentication.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("RapidPay.Domain.Payment.Models.CreditCard", b =>
                {
                    b.HasOne("RapidPay.Domain.Authentication.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("CreditCards")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("RapidPay.Domain.Store.Models.Purchase", b =>
                {
                    b.HasOne("RapidPay.Domain.Payment.Models.CreditCard", "CreditCard")
                        .WithMany("Purchases")
                        .HasForeignKey("CreditCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RapidPay.Domain.Store.Models.Product", "Product")
                        .WithMany("Purchases")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreditCard");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("RapidPay.Domain.Authentication.Models.ApplicationUser", b =>
                {
                    b.Navigation("CreditCards");

                    b.Navigation("UserClaims");
                });

            modelBuilder.Entity("RapidPay.Domain.Payment.Models.CreditCard", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("RapidPay.Domain.Store.Models.Product", b =>
                {
                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}