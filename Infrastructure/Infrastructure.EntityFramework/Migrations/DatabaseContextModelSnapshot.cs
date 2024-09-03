﻿// <auto-generated />
using System;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreateDate = new DateTime(2022, 2, 28, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            Name = "Student",
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2L,
                            CreateDate = new DateTime(2022, 1, 31, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            Name = "Teacher",
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3L,
                            CreateDate = new DateTime(2021, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            Name = "Administrator",
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Hash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime>("UpDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreateDate = new DateTime(2021, 12, 14, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            Email = "root",
                            FirstName = "root",
                            Hash = new byte[] { 21, 89, 190, 241, 252, 86, 45, 148, 227, 4, 190, 232, 124, 30, 77, 70, 43, 211, 151, 104 },
                            LastName = "root",
                            Salt = new byte[] { 70, 218, 10, 125, 133, 170, 236, 193, 122, 147, 255, 100, 189, 170, 191, 243, 204, 199, 13, 118 },
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 2L,
                            CreateDate = new DateTime(2022, 1, 13, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            Email = "kovJ11@gmail.com",
                            FirstName = "Jane",
                            Hash = new byte[] { 240, 178, 9, 149, 136, 53, 111, 195, 46, 32, 194, 152, 17, 182, 139, 173, 6, 220, 130, 40 },
                            LastName = "Kovalski",
                            Salt = new byte[] { 234, 110, 84, 92, 115, 249, 254, 245, 205, 76, 104, 67, 126, 38, 92, 180, 35, 178, 136, 44 },
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            Id = 3L,
                            CreateDate = new DateTime(2022, 12, 10, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            Email = "sergVVV@gmail.com",
                            FirstName = "Sergey",
                            Hash = new byte[] { 245, 127, 178, 126, 37, 21, 77, 253, 152, 28, 55, 128, 170, 79, 193, 83, 250, 92, 254, 234 },
                            LastName = "Vasiliev",
                            Salt = new byte[] { 204, 182, 201, 37, 141, 244, 10, 109, 101, 37, 212, 145, 224, 11, 83, 49, 108, 50, 83, 31 },
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.Property<long>("User_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Role_Id")
                        .HasColumnType("bigint");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("UpDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("User_Id", "Role_Id", "Id");

                    b.HasIndex("Role_Id");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            RoleId = 3L,
                            Id = 1L,
                            CreateDate = new DateTime(2022, 3, 11, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            UserId = 2L,
                            RoleId = 2L,
                            Id = 2L,
                            CreateDate = new DateTime(2022, 6, 9, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        },
                        new
                        {
                            UserId = 3L,
                            RoleId = 1L,
                            Id = 3L,
                            CreateDate = new DateTime(2022, 7, 16, 21, 0, 0, 0, DateTimeKind.Utc),
                            Deleted = false,
                            UpDate = new DateTime(1969, 12, 31, 21, 0, 0, 0, DateTimeKind.Utc)
                        });
                });

            modelBuilder.Entity("Domain.Entities.UserRole", b =>
                {
                    b.HasOne("Domain.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("Role_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}