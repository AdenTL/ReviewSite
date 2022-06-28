﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using template_csharp_reviews_site;

#nullable disable

namespace template_csharp_reviews_site.Migrations
{
    [DbContext(typeof(VideoGameContext))]
    [Migration("20220628160407_newbuild-Rev")]
    partial class newbuildRev
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("template_csharp_reviews_site.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewBody")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VideoGameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoGameId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = "Fall guys is awesome",
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 8,
                            ReviewBody = "Just a fun game to mess with my friends. I loved just knocking them off the levels, every time I got the chance.. 'Bang' .",
                            User = "John Doe",
                            VideoGameId = 1
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Bloodhunt is alright",
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 6,
                            ReviewBody = "Good idea with what they were going for. Love the gameplay and a new style to these types of game.",
                            User = "Jane Doe",
                            VideoGameId = 2
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Fortnite sucks",
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 3,
                            ReviewBody = "I would do lower but it was good to pump shotgun some noobs.",
                            User = "Jonnathan Doe",
                            VideoGameId = 3
                        },
                        new
                        {
                            Id = 4,
                            Comment = "Apex Legends is decent",
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 5,
                            ReviewBody = "work the playtime, but too many lootboxes and pay-to-win mechanics.",
                            User = "John Deer",
                            VideoGameId = 4
                        },
                        new
                        {
                            Id = 5,
                            Comment = "Warzone is horrible",
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 1,
                            ReviewBody = "Warzone was a cashgrab that stole my money.",
                            User = "Jack Doe",
                            VideoGameId = 5
                        },
                        new
                        {
                            Id = 6,
                            Comment = "PUBG Moblie is decent",
                            PublishDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 9,
                            ReviewBody = "PUBG Moblie is decent for this year's showcase",
                            User = "Jackline O'Connor",
                            VideoGameId = 6
                        });
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Studio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fall Guys",
                            Studio = "Mediatonic"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bloodhunt",
                            Studio = "Sharkmob"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fortnite",
                            Studio = "Epic Games"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Apex Legends",
                            Studio = "Respawn"
                        },
                        new
                        {
                            Id = 5,
                            Name = "COD: Warzone",
                            Studio = "Acti-Blizz"
                        },
                        new
                        {
                            Id = 6,
                            Name = "PUBG Moblie",
                            Studio = "PUBG Studios/Krafton"
                        });
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.Review", b =>
                {
                    b.HasOne("template_csharp_reviews_site.Models.VideoGame", "VideoGame")
                        .WithMany("Reviews")
                        .HasForeignKey("VideoGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VideoGame");
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.VideoGame", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}