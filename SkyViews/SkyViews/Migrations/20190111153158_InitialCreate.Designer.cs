﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkyViews.Models;

namespace SkyViews.Migrations
{
    [DbContext(typeof(SkyViewsContext))]
    [Migration("20190111153158_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkyViews.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID");

                    b.Property<int>("SeatNo");

                    b.Property<int>("ShowingID");

                    b.HasKey("BookingID");

                    b.HasIndex("ShowingID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("SkyViews.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<int>("TelephoneNo");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SkyViews.Models.Film", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cast");

                    b.Property<string>("Director");

                    b.Property<string>("ImagePath");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("RunningTime");

                    b.Property<string>("Synopsis");

                    b.Property<string>("Title");

                    b.HasKey("FilmID");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("SkyViews.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NoOfSeats");

                    b.HasKey("RoomID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("SkyViews.Models.Showing", b =>
                {
                    b.Property<int>("ShowingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmID");

                    b.Property<int>("RoomID");

                    b.Property<DateTime>("ShowingTime");

                    b.HasKey("ShowingID");

                    b.HasIndex("FilmID");

                    b.HasIndex("RoomID");

                    b.ToTable("Showing");
                });

            modelBuilder.Entity("SkyViews.Models.Booking", b =>
                {
                    b.HasOne("SkyViews.Models.Showing", "Showing")
                        .WithMany()
                        .HasForeignKey("ShowingID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SkyViews.Models.Showing", b =>
                {
                    b.HasOne("SkyViews.Models.Film", "Film")
                        .WithMany("Showing")
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SkyViews.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
