﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolOf.Data;

namespace SchoolOf.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210909154306_ChangeDescriptionLength")]
    partial class ChangeDescriptionLength
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolOf.Data.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("ModifiedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Category = "Cars",
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 250, DateTimeKind.Unspecified).AddTicks(2993), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean feugiat leo aliquet purus tempor congue. Nam ut lacus metus. Morbi suscipit, urna at fringilla lobortis, libero justo pharetra odio, sagittis vehicula arcu orci tincidunt est. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.",
                            Image = "",
                            IsDeleted = false,
                            ModifiedAt = new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 250, DateTimeKind.Unspecified).AddTicks(3261), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Dacia Logan",
                            Price = 10000m
                        },
                        new
                        {
                            Id = 2L,
                            Category = "Cars",
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 250, DateTimeKind.Unspecified).AddTicks(3514), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Proin dignissim nisi id urna laoreet malesuada tristique ac eros. Aliquam vehicula congue scelerisque. Vestibulum ut orci nec lacus porttitor interdum maximus nec est.",
                            Image = "",
                            IsDeleted = false,
                            ModifiedAt = new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 250, DateTimeKind.Unspecified).AddTicks(3517), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "Open Astra K",
                            Price = 16500m
                        },
                        new
                        {
                            Id = 3L,
                            Category = "Cars",
                            CreatedAt = new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 250, DateTimeKind.Unspecified).AddTicks(3519), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Yes",
                            Image = "",
                            IsDeleted = false,
                            ModifiedAt = new DateTimeOffset(new DateTime(2021, 9, 9, 15, 43, 6, 250, DateTimeKind.Unspecified).AddTicks(3520), new TimeSpan(0, 0, 0, 0, 0)),
                            Name = "VW Golf 7",
                            Price = 19500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}