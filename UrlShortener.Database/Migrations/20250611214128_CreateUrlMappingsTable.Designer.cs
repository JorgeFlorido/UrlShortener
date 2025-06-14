﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using URLShortener.Database;

#nullable disable

namespace UrlShortener.Database.Migrations
{
    [DbContext(typeof(UrlShortenerDbContext))]
    [Migration("20250611214128_CreateUrlMappingsTable")]
    partial class CreateUrlMappingsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.6");

            modelBuilder.Entity("URLShortener.Domain.Models.UrlMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginalUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ShortenedUrl")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShortenedUrl")
                        .IsUnique();

                    b.ToTable("UrlMappings");
                });
#pragma warning restore 612, 618
        }
    }
}
