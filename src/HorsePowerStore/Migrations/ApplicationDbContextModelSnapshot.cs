﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using HorsePowerStore.Data;

namespace HorsePowerStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HorsePowerStore.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HorsePowerStore.Models.CarInstance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Name");

                    b.Property<int?>("StyleId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("StyleId");

                    b.ToTable("CarInstances");
                });

            modelBuilder.Entity("HorsePowerStore.Models.CarMod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("HorsePower");

                    b.Property<int?>("ProductId");

                    b.Property<int?>("StyleId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("StyleId");

                    b.ToTable("CarMods");
                });

            modelBuilder.Entity("HorsePowerStore.Models.CarModSelection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CarInstanceId");

                    b.Property<int?>("CarModId");

                    b.HasKey("Id");

                    b.HasIndex("CarInstanceId");

                    b.HasIndex("CarModId");

                    b.ToTable("CarModSelections");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Make", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Makes");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("MakeId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("MakeId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("ImageSource");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("PurchaseURL");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Message");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProductId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Style", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Horsepower");

                    b.Property<string>("Name");

                    b.Property<int?>("YearId");

                    b.HasKey("Id");

                    b.HasIndex("YearId");

                    b.ToTable("Styles");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Year", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ModelId");

                    b.Property<int>("Years");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Years");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HorsePowerStore.Models.CarInstance", b =>
                {
                    b.HasOne("HorsePowerStore.Models.ApplicationUser")
                        .WithMany("CarInstances")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("HorsePowerStore.Models.Style", "Style")
                        .WithMany()
                        .HasForeignKey("StyleId");
                });

            modelBuilder.Entity("HorsePowerStore.Models.CarMod", b =>
                {
                    b.HasOne("HorsePowerStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("HorsePowerStore.Models.Style", "Style")
                        .WithMany()
                        .HasForeignKey("StyleId");
                });

            modelBuilder.Entity("HorsePowerStore.Models.CarModSelection", b =>
                {
                    b.HasOne("HorsePowerStore.Models.CarInstance", "CarInstance")
                        .WithMany("SelectedCarMods")
                        .HasForeignKey("CarInstanceId");

                    b.HasOne("HorsePowerStore.Models.CarMod", "CarMod")
                        .WithMany()
                        .HasForeignKey("CarModId");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Model", b =>
                {
                    b.HasOne("HorsePowerStore.Models.Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Rating", b =>
                {
                    b.HasOne("HorsePowerStore.Models.ApplicationUser")
                        .WithMany("Ratings")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("HorsePowerStore.Models.Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Style", b =>
                {
                    b.HasOne("HorsePowerStore.Models.Year")
                        .WithMany("Styles")
                        .HasForeignKey("YearId");
                });

            modelBuilder.Entity("HorsePowerStore.Models.Year", b =>
                {
                    b.HasOne("HorsePowerStore.Models.Model")
                        .WithMany("Years")
                        .HasForeignKey("ModelId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HorsePowerStore.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HorsePowerStore.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HorsePowerStore.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
